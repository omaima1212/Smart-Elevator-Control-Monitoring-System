using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
namespace SMART_ELEVATOR
{
    public partial class ElevatorDashboard : Form
    {
        // LABVIEW TCP CONNECTION
        private TcpClient tcpClient;
        private NetworkStream tcpStream;
        private bool tcpConnected = false;

        // LABVIEW STATUS RECEIVER
        private System.Threading.Thread receiveThread;
        private volatile bool receivingStatus = false;
        private readonly object tcpLock = new object(); 
        // MOVEMENT VARIABLES
        private Timer movementTimer;
        private int targetY;
        private int currentFloor = 2;
        private int targetFloor;
        private bool emergencyActive = false;
        // TRACK INTERRUPTED MOVEMENT
        private bool journeyInterruptedByEmergency = false;
        // ELEVATOR REQUEST QUEUE
        private Queue<HallCallRequest> requestQueue = new Queue<HallCallRequest>();
        // DIRECTION-AWARE ELEVATOR REQUEST
        private class HallCallRequest
        {
            public int Floor;
            public string Direction;

            public HallCallRequest(int floor, string direction)
            {
                Floor = floor;
                Direction = direction;
            }
        }
        private HashSet<string> pendingRequests = new HashSet<string>();
        // INTELLIGENT SCHEDULING VARIABLES
        private int finalDestinationFloor;
        private bool hasIntermediateStop = false;

        // DIRECTION TRACKING
        private string finalDestinationDirection;
        private string targetRequestDirection;
        // DOOR ANIMATION VARIABLES
        private Timer doorTimer;
        private Timer autoCloseTimer;
        private int doorProgress = 0;
        private bool doorOpening = false;
        private Panel leftDoor;
        private Panel rightDoor;
        // DOOR SAFETY SENSOR
        private bool obstacleDetected = false;
        // FLOOR POSITIONS INSIDE THE SHAFT
        private readonly int[] floorPositions = { 261, 150, 56};

        public ElevatorDashboard()
        {
            InitializeComponent();

            this.Shown += (s, e) =>
            {
                if (tcpConnected)
                {
                    receivingStatus = true;

                    this.FormClosing += (sender, args) =>
                    {
                        receivingStatus = false;
                        tcpConnected = false;

                        if (tcpStream != null)
                            tcpStream.Close();

                        if (tcpClient != null)
                            tcpClient.Close();
                    };

                    receiveThread = new System.Threading.Thread(ReceiveStatusLoop);
                    receiveThread.IsBackground = true;
                    receiveThread.Start();
                }
            };

            ConnectToLabVIEW();

            UpdateDirectionArrow();

            // INITIALIZE MOVEMENT TIMER
            movementTimer = new Timer();
            movementTimer.Interval = 10;
            movementTimer.Tick += MovementTimer_Tick;
            // INITIALIZE DOOR TIMER
            doorTimer = new Timer();
            doorTimer.Interval = 10;
            doorTimer.Tick += DoorTimer_Tick;
            autoCloseTimer = new Timer();
            autoCloseTimer.Interval = 3000;
            autoCloseTimer.Tick += AutoCloseTimer_Tick;
            // CREATE LEFT DOOR
            leftDoor = new Panel();
            leftDoor.Size = new Size(90, 65);
            leftDoor.Location = new Point(0, 0);
            leftDoor.BackColor = Color.LightGray;
            leftDoor.BorderStyle = BorderStyle.FixedSingle;

            // CREATE RIGHT DOOR
            rightDoor = new Panel();
            rightDoor.Size = new Size(90, 65);
            rightDoor.Location = new Point(90, 0);
            rightDoor.BackColor = Color.LightGray;
            rightDoor.BorderStyle = BorderStyle.FixedSingle;

            // ADD DOORS TO ELEVATOR CABIN
            pnlCabin.Controls.Add(leftDoor);
            pnlCabin.Controls.Add(rightDoor);
            leftDoor.BringToFront();
            rightDoor.BringToFront();
        }
        // CONNECT TO LABVIEW TCP SERVER
        private void ConnectToLabVIEW()
        {
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect("127.0.0.1", 5000);

                tcpStream = tcpClient.GetStream();
                tcpConnected = true;


                MessageBox.Show("Connected to LabVIEW successfully!");
            }
            catch (Exception ex)
            {
                tcpConnected = false;

                MessageBox.Show(
                    "Could not connect to LabVIEW: " + ex.Message);
            }
        }
        // SEND COMMAND TO LABVIEW
        private void SendCommand(string command)
        {
            try
            {
                if (tcpConnected && tcpStream != null)
                {
                    byte[] data = System.Text.Encoding.ASCII.GetBytes(command);
                    tcpStream.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                tcpConnected = false;
                MessageBox.Show("TCP communication error: " + ex.Message);
            }
        }
        // RECEIVE ELEVATOR STATUS FROM LABVIEW
        private void ReceiveStatusLoop()
        {
            StringBuilder buffer = new StringBuilder();

            try
            {
                while (receivingStatus && tcpConnected)
                {
                    int value = tcpStream.ReadByte();

                    if (value == -1)
                        break;

                    char character = (char)value;

                    if (character == '\n')
                    {
                        string status = buffer.ToString().Trim();
                        buffer.Clear();

                        if (!string.IsNullOrEmpty(status))
                        {
                            BeginInvoke(new Action(() =>
                            {
                                ProcessLabVIEWStatus(status);
                            }));
                        }
                    }
                    else
                    {
                        buffer.Append(character);
                    }
                }
            }
            catch (Exception)
            {
                tcpConnected = false;
            }
        }
        // SYNCHRONIZE CABIN POSITION WITH LABVIEW
        // SYNCHRONIZE CABIN MOVEMENT WITH LABVIEW
        private void ProcessLabVIEWStatus(string status)
        {
            string[] values = status.Split(',');

            if (values.Length != 7)
                return;

            int position;
            int destination;
            int motor;
            int direction;

            if (!int.TryParse(values[0].Trim(), out position) ||
                !int.TryParse(values[1].Trim(), out destination) ||
                !int.TryParse(values[2].Trim(), out motor) ||
                !int.TryParse(values[3].Trim(), out direction))
                return;

            if (position < 0 || position > 2 ||
                destination < 0 || destination > 2)
                return;

            if (emergencyActive)
                return;

            // LabVIEW controls the movement
            if (motor == 1)
            {
                targetFloor = destination;
                targetY = floorPositions[destination];

                if (direction == 1)
                    lblDirectionValue.Text = "UP";
                else if (direction == 2)
                    lblDirectionValue.Text = "DOWN";

                UpdateDirectionArrow();

                lblMotorValue.Text = "RUNNING";

                if (!movementTimer.Enabled)
                    movementTimer.Start();
            }
            else
            {
                // Stop when LabVIEW reports that the moto
                // r has stopped
                movementTimer.Stop();

                currentFloor = position;
                pnlCabin.Top = floorPositions[position];

                lblFloorValue.Text = "FLOOR " + position;
                lblMotorValue.Text = "STOPPED";
                lblDirectionValue.Text = "STOPPED";

                UpdateDirectionArrow();
            }
        }
        // MOVE ELEVATOR TO A SELECTED FLOOR
        // ADD A FLOOR REQUEST TO THE QUEUE
        // ADD A DIRECTION-AWARE REQUEST TO THE QUEUE
        private void MoveToFloor(int floor, string direction)
        {
            if (emergencyActive)
                return;

            if (floor < 0 || floor > 2)
                return;

            // IDENTIFY THE REQUEST BY FLOOR AND DIRECTION
            string requestKey = floor + "_" + direction;

            // AVOID DUPLICATE REQUESTS
            if (pendingRequests.Contains(requestKey))
                return;

            pendingRequests.Add(requestKey);

            requestQueue.Enqueue(new HallCallRequest(floor, direction));

            // PROCESS REQUESTS WHEN THE ELEVATOR IS IDLE
            if (!movementTimer.Enabled && lblDoorValue.Text == "CLOSED")
            {
                ProcessNextRequest();
            }
        }
        // HANDLE CABIN FLOOR SELECTION
        private void RequestCabinFloor(int floor)
        {
            if (emergencyActive)
                return;

            string direction;

            if (floor > currentFloor)
                direction = "UP";
            else if (floor < currentFloor)
                direction = "DOWN";
            else
                direction = lblDirectionValue.Text == "DOWN" ? "DOWN" : "UP";

            MoveToFloor(floor, direction);
        }
        // UPDATE DIRECTION ARROW
        private void UpdateDirectionArrow()
        {
            if (lblDirectionValue.Text == "UP")
            {
                lblDirectionArrow.Text = "▲";
                lblDirectionArrow.ForeColor = Color.Green;
            }
            else if (lblDirectionValue.Text == "DOWN")
            {
                lblDirectionArrow.Text = "▼";
                lblDirectionArrow.ForeColor = Color.Red;
            }
            else
            {
                lblDirectionArrow.Text = "●";
                lblDirectionArrow.ForeColor = Color.Gray;
            }
        }
        // PROCESS THE NEXT FLOOR REQUEST
        private void ProcessNextRequest()
        {
            if (emergencyActive)
                return;

            if (movementTimer.Enabled || doorTimer.Enabled)
                return;

            if (lblDoorValue.Text != "CLOSED")
                return;

            // RESUME THE ORIGINAL JOURNEY AFTER AN INTERMEDIATE STOP
            if (hasIntermediateStop)
            {
                hasIntermediateStop = false;


                targetRequestDirection = finalDestinationDirection;


                targetFloor = finalDestinationFloor;
                targetY = floorPositions[finalDestinationFloor];

                if (pnlCabin.Top > targetY)
                    lblDirectionValue.Text = "UP";
                else
                    lblDirectionValue.Text = "DOWN";

                UpdateDirectionArrow();
                
                lblMotorValue.Text = "RUNNING";
                movementTimer.Start();

                return;
            }

            if (requestQueue.Count == 0)
                return;
            HallCallRequest nextRequest = requestQueue.Dequeue();

            

            int nextFloor = nextRequest.Floor;
            string nextDirection = nextRequest.Direction;

            finalDestinationFloor = nextFloor;
            finalDestinationDirection = nextDirection;

            targetRequestDirection = nextDirection;

            hasIntermediateStop = false;

            targetFloor = nextFloor;
            targetY = floorPositions[nextFloor];

            if (pnlCabin.Top > targetY)
                lblDirectionValue.Text = "UP";
            else if (pnlCabin.Top < targetY)
                lblDirectionValue.Text = "DOWN";
            else
            {
                ResetHallCallButtons(nextFloor);

                lblFloorValue.Text = "FLOOR " + nextFloor;
                lblMotorValue.Text = "STOPPED";
                lblDirectionValue.Text = "STOPPED";

                UpdateDirectionArrow();

                doorOpening = true;
                doorTimer.Start();
                return;
            }
            UpdateDirectionArrow();

            lblMotorValue.Text = "RUNNING";
            movementTimer.Start();
        }
        // FIND A REQUESTED FLOOR ON THE CURRENT ROUTE
        // FIND A REQUESTED FLOOR ON THE CURRENT ROUTE
        private bool TryGetIntermediateStop(out int stopFloor)
        {
            stopFloor = -1;

            int cabinPosition = pnlCabin.Top;
            int selectedFloor = -1;
            string selectedDirection = "";

            // ELEVATOR MOVING UP
            if (cabinPosition > targetY)
            {
                int closestPosition = int.MinValue;

                foreach (HallCallRequest request in requestQueue)
                {
                    int floor = request.Floor;
                    int position = floorPositions[floor];

                    // ONLY ACCEPT UP REQUESTS
                    if (request.Direction != "UP")
                        continue;

                    if (floor == finalDestinationFloor)
                        continue;

                    if (position < cabinPosition &&
                        position > targetY &&
                        position > closestPosition)
                    {
                        closestPosition = position;
                        selectedFloor = floor;
                        selectedDirection = request.Direction;
                    }
                }
            }
            // ELEVATOR MOVING DOWN
            else if (cabinPosition < targetY)
            {
                int closestPosition = int.MaxValue;

                foreach (HallCallRequest request in requestQueue)
                {
                    int floor = request.Floor;
                    int position = floorPositions[floor];

                    // ONLY ACCEPT DOWN REQUESTS
                    if (request.Direction != "DOWN")
                        continue;

                    if (floor == finalDestinationFloor)
                        continue;

                    if (position > cabinPosition &&
                        position < targetY &&
                        position < closestPosition)
                    {
                        closestPosition = position;
                        selectedFloor = floor;
                        selectedDirection = request.Direction;
                    }
                }
            }

            if (selectedFloor == -1)
                return false;

            // REMOVE ONLY THE SELECTED FLOOR AND DIRECTION
            Queue<HallCallRequest> remainingRequests =
                new Queue<HallCallRequest>();

            while (requestQueue.Count > 0)
            {
                HallCallRequest request = requestQueue.Dequeue();

                if (request.Floor != selectedFloor ||
                    request.Direction != selectedDirection)
                {
                    remainingRequests.Enqueue(request);
                }
            }

            requestQueue = remainingRequests;

            targetRequestDirection = selectedDirection;

            stopFloor = selectedFloor;
            return true;
        }
        // RESET HALL CALL BUTTON COLORS WHEN THE ELEVATOR ARRIVES
        private void ResetHallCallButtons(int floor)
        {
            if (floor == 0)
            {
                btnCallGroundUp.BackColor = Color.LightSkyBlue;
            }
            else if (floor == 1)
            {
                btnCallFloor1Up.BackColor = Color.LightSkyBlue;
                btnCallFloor1Down.BackColor = Color.LightSalmon;
            }
            else if (floor == 2)
            {
                btnCallFloor2Down.BackColor = Color.LightSalmon;
            }
        }
        // TIMER: ANIMATE CABIN MOVEMENT
        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            int speed = 2;

            if (pnlCabin.Top > targetY)
            {
                pnlCabin.Top -= speed;

                if (pnlCabin.Top < targetY)
                    pnlCabin.Top = targetY;
            }
            else if (pnlCabin.Top < targetY)
            {
                pnlCabin.Top += speed;

                if (pnlCabin.Top > targetY)
                    pnlCabin.Top = targetY;
            }

            // CHECK FOR AN INTERMEDIATE FLOOR REQUEST
            int intermediateFloor;

            if (TryGetIntermediateStop(out intermediateFloor))
            {
                targetFloor = intermediateFloor;
                targetY = floorPositions[intermediateFloor];
            }

            // CHECK IF THE CURRENT TARGET HAS BEEN REACHED
            if (pnlCabin.Top == targetY)
            {
                movementTimer.Stop();

                currentFloor = targetFloor;

                // REMOVE THE COMPLETED FLOOR AND DIRECTION REQUEST
                string completedRequestKey = currentFloor + "_" + targetRequestDirection;
                pendingRequests.Remove(completedRequestKey);

                ResetHallCallButtons(currentFloor);

                lblFloorValue.Text = "FLOOR " + currentFloor;
                lblMotorValue.Text = "STOPPED";
                lblDirectionValue.Text = "STOPPED";

                UpdateDirectionArrow();

                // REMEMBER IF THIS IS AN INTERMEDIATE STOP
                if (currentFloor != finalDestinationFloor)
                    hasIntermediateStop = true;

                // AUTOMATICALLY OPEN THE DOORS
                doorOpening = true;
                doorTimer.Start();
            }

        }
        // TIMER: ANIMATE ELEVATOR DOORS
        private void DoorTimer_Tick(object sender, EventArgs e)
        {
            if (doorOpening)
            {
                doorProgress += 3;

                if (doorProgress >= 90)
                {
                    doorProgress = 90;
                    doorTimer.Stop();
                    lblDoorValue.Text = "OPEN";

                    // CLOSE AUTOMATICALLY ONLY IF NO OBSTACLE EXISTS
                    if (!obstacleDetected)
                    {
                        autoCloseTimer.Start();
                    }
                }
            }
            else
            {
                // CHECK FOR AN OBSTACLE BEFORE CLOSING
                if (obstacleDetected)
                {
                    doorOpening = true;
                    return;
                }

                doorProgress -= 3;

                if (doorProgress <= 0)
                {
                    doorProgress = 0;
                    doorTimer.Stop();
                    lblDoorValue.Text = "CLOSED";
                    // PROCESS THE NEXT WAITING REQUEST
                    ProcessNextRequest();
                }
            }

            // Move both doors
            leftDoor.Left = -doorProgress;
            rightDoor.Left = 90 + doorProgress;
        }
        // AUTOMATICALLY CLOSE DOORS AFTER 3 SECONDS
        private void AutoCloseTimer_Tick(object sender, EventArgs e)
        {
            autoCloseTimer.Stop();

            doorOpening = false;
            doorTimer.Start();
        }
        // GROUND FLOOR BUTTON
        private void btnFloor0_Click(object sender, EventArgs e)
        {
            SendCommand("0");
            RequestCabinFloor(0);
        }

        // FLOOR 1 BUTTON
        private void btnFloor1_Click(object sender, EventArgs e)
        {
            SendCommand("1");
            RequestCabinFloor(1);
        }

        // FLOOR 2 BUTTON
        private void btnFloor2_Click(object sender, EventArgs e)
        {
            SendCommand("2");
            RequestCabinFloor(2);
        }
        // UP BUTTON
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (currentFloor < 2)
                MoveToFloor(currentFloor + 1, "UP");
        }

        // DOWN BUTTON
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (currentFloor > 0)
                MoveToFloor(currentFloor - 1, "DOWN");
        }
        // OPEN DOOR BUTTON
        private void btnOpenDoor_Click(object sender, EventArgs e)
        {
            if (emergencyActive)
                return;

            if (movementTimer.Enabled)
            {
                MessageBox.Show("Cannot open the door while the elevator is moving.",
                                "Door Safety",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (pnlCabin.Top != floorPositions[0] &&
                pnlCabin.Top != floorPositions[1] &&
                pnlCabin.Top != floorPositions[2])
            {
                MessageBox.Show("The door can only open when the elevator is at a floor.",
                                "Door Safety",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            doorOpening = true;
            doorTimer.Start();
        }
        // CLOSE DOOR BUTTON
        private void btnCloseDoor_Click(object sender, EventArgs e)
        {
            autoCloseTimer.Stop();

            doorOpening = false;
            doorTimer.Start();
        }
        // EMERGENCY STOP BUTTON
        private void btnEmergency_Click(object sender, EventArgs e)
        {
            if (!emergencyActive)
            {
                SendCommand("E");

                // ACTIVATE EMERGENCY
                emergencyActive = true;

                // REMEMBER IF THE ELEVATOR WAS MOVING
                journeyInterruptedByEmergency = movementTimer.Enabled;

                movementTimer.Stop();

                lblMotorValue.Text = "STOPPED";
                lblDirectionValue.Text = "STOPPED";

                lblEmergencyValue.Text = "EMERGENCY";
                lblEmergencyValue.ForeColor = Color.Red;
                lblEmergencyValue.BackColor = Color.LightPink;

                btnEmergency.Text = "RESET EMERGENCY";
            }
            else
            {
                SendCommand("R");

                // RESET EMERGENCY
                emergencyActive = false;

                ResetEmergencyStatus();

                btnEmergency.Text = "EMERGENCY STOP";

                // RESUME INTERRUPTED JOURNEY
                if (journeyInterruptedByEmergency)
                {
                    journeyInterruptedByEmergency = false;

                    if (pnlCabin.Top > targetY)
                        lblDirectionValue.Text = "UP";
                    else
                        lblDirectionValue.Text = "DOWN";
                    UpdateDirectionArrow();

                    lblMotorValue.Text = "RUNNING";
                    movementTimer.Start();
                }
                else
                {
                    // PROCESS WAITING REQUESTS IF POSSIBLE
                    ProcessNextRequest();
                }
            }
        }
        // RESTORE NORMAL STATUS
        private void ResetEmergencyStatus()
        {
            lblEmergencyValue.Text = "NORMAL";
            lblEmergencyValue.ForeColor = Color.Green;
            lblEmergencyValue.BackColor = Color.LightGreen;
        }

        // EXISTING DESIGNER EVENT HANDLERS
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void pnlShaft_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnCallGroundUp_Click(object sender, EventArgs e)
        {
            btnCallGroundUp.BackColor = Color.Orange;
            MoveToFloor(0, "UP");

        }

        private void btnCallFloor1Down_Click(object sender, EventArgs e)
        {
            btnCallFloor1Down.BackColor = Color.Orange;
            MoveToFloor(1, "DOWN");
        }

        private void btnCallFloor1Up_Click(object sender, EventArgs e)
        {
            btnCallFloor1Up.BackColor = Color.Orange;
            MoveToFloor(1, "UP");
        }

        private void btnCallFloor2Down_Click(object sender, EventArgs e)
        {
            btnCallFloor2Down.BackColor = Color.Orange;
            MoveToFloor(2, "DOWN");
        }

        private void btnObstacle_Click(object sender, EventArgs e)
        {
            if (!obstacleDetected)
            {
                // ACTIVATE OBSTACLE SENSOR
                obstacleDetected = true;

                autoCloseTimer.Stop();

                btnObstacle.Text = "OBSTACLE: ON";
                btnObstacle.BackColor = Color.LightCoral;

                // REOPEN DOORS IF THEY ARE CLOSING
                if (!doorOpening && doorTimer.Enabled)
                {
                    doorOpening = true;
                }
            }
            else
            {
                // DEACTIVATE OBSTACLE SENSOR
                obstacleDetected = false;

                btnObstacle.Text = "OBSTACLE: OFF";
                btnObstacle.BackColor = Color.LightGreen;

                // RESTART AUTOMATIC CLOSING IF DOORS ARE OPEN
                if (doorProgress >= 90 && !doorTimer.Enabled)
                {
                    autoCloseTimer.Start();
                }
            }
        }
    }
}