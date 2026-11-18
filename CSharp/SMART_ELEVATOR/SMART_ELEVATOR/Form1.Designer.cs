namespace SMART_ELEVATOR
{
    partial class ElevatorDashboard
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlElevator = new System.Windows.Forms.Panel();
            this.lblDirectionArrow = new System.Windows.Forms.Label();
            this.btnObstacle = new System.Windows.Forms.Button();
            this.grpHallCall = new System.Windows.Forms.GroupBox();
            this.btnCallFloor2Down = new System.Windows.Forms.Button();
            this.btnCallFloor1Down = new System.Windows.Forms.Button();
            this.btnCallFloor1Up = new System.Windows.Forms.Button();
            this.btnCallGroundUp = new System.Windows.Forms.Button();
            this.lblMonitoringTitle = new System.Windows.Forms.Label();
            this.lblEmergencyValue = new System.Windows.Forms.Label();
            this.lblEmergencyStatus = new System.Windows.Forms.Label();
            this.lblDirectionValue = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblDoorValue = new System.Windows.Forms.Label();
            this.lblDoorStatus = new System.Windows.Forms.Label();
            this.lblMotorValue = new System.Windows.Forms.Label();
            this.lblMotorStatus = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblFloor0 = new System.Windows.Forms.Label();
            this.lblFloor1 = new System.Windows.Forms.Label();
            this.pnlShaft = new System.Windows.Forms.Panel();
            this.pnlCabin = new System.Windows.Forms.Panel();
            this.lblCabin = new System.Windows.Forms.Label();
            this.lblFloorValue = new System.Windows.Forms.Label();
            this.lblCurrentFloor = new System.Windows.Forms.Label();
            this.lblFloor2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblElevatorTitle = new System.Windows.Forms.Label();
            this.pnlMonitoring = new System.Windows.Forms.Panel();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.btnCloseDoor = new System.Windows.Forms.Button();
            this.btnOpenDoor = new System.Windows.Forms.Button();
            this.btnFloor2 = new System.Windows.Forms.Button();
            this.btnFloor1 = new System.Windows.Forms.Button();
            this.btnFloor0 = new System.Windows.Forms.Button();
            this.lblControlsTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlElevator.SuspendLayout();
            this.grpHallCall.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlShaft.SuspendLayout();
            this.pnlCabin.SuspendLayout();
            this.pnlMonitoring.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1182, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(547, 82);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SMART ELEVATOR CONTROL SYSTEM\r\n\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlElevator
            // 
            this.pnlElevator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.pnlElevator.Controls.Add(this.lblDirectionArrow);
            this.pnlElevator.Controls.Add(this.btnObstacle);
            this.pnlElevator.Controls.Add(this.grpHallCall);
            this.pnlElevator.Controls.Add(this.lblMonitoringTitle);
            this.pnlElevator.Controls.Add(this.lblEmergencyValue);
            this.pnlElevator.Controls.Add(this.lblEmergencyStatus);
            this.pnlElevator.Controls.Add(this.lblDirectionValue);
            this.pnlElevator.Controls.Add(this.lblDirection);
            this.pnlElevator.Controls.Add(this.lblDoorValue);
            this.pnlElevator.Controls.Add(this.lblDoorStatus);
            this.pnlElevator.Controls.Add(this.lblMotorValue);
            this.pnlElevator.Controls.Add(this.lblMotorStatus);
            this.pnlElevator.Location = new System.Drawing.Point(20, 100);
            this.pnlElevator.Name = "pnlElevator";
            this.pnlElevator.Size = new System.Drawing.Size(350, 550);
            this.pnlElevator.TabIndex = 1;
            // 
            // lblDirectionArrow
            // 
            this.lblDirectionArrow.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectionArrow.Location = new System.Drawing.Point(116, 260);
            this.lblDirectionArrow.Name = "lblDirectionArrow";
            this.lblDirectionArrow.Size = new System.Drawing.Size(35, 35);
            this.lblDirectionArrow.TabIndex = 10;
            this.lblDirectionArrow.Text = "●";
            this.lblDirectionArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnObstacle
            // 
            this.btnObstacle.BackColor = System.Drawing.Color.LightGreen;
            this.btnObstacle.Location = new System.Drawing.Point(196, 353);
            this.btnObstacle.Name = "btnObstacle";
            this.btnObstacle.Size = new System.Drawing.Size(141, 48);
            this.btnObstacle.TabIndex = 10;
            this.btnObstacle.Text = "OBSTACLE: OFF";
            this.btnObstacle.UseVisualStyleBackColor = false;
            this.btnObstacle.Click += new System.EventHandler(this.btnObstacle_Click);
            // 
            // grpHallCall
            // 
            this.grpHallCall.Controls.Add(this.btnCallFloor2Down);
            this.grpHallCall.Controls.Add(this.btnCallFloor1Down);
            this.grpHallCall.Controls.Add(this.btnCallFloor1Up);
            this.grpHallCall.Controls.Add(this.btnCallGroundUp);
            this.grpHallCall.Location = new System.Drawing.Point(10, 405);
            this.grpHallCall.Name = "grpHallCall";
            this.grpHallCall.Size = new System.Drawing.Size(320, 135);
            this.grpHallCall.TabIndex = 17;
            this.grpHallCall.TabStop = false;
            this.grpHallCall.Text = "HALL CALL PANEL";
            // 
            // btnCallFloor2Down
            // 
            this.btnCallFloor2Down.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCallFloor2Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCallFloor2Down.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallFloor2Down.ForeColor = System.Drawing.Color.Black;
            this.btnCallFloor2Down.Location = new System.Drawing.Point(165, 65);
            this.btnCallFloor2Down.Name = "btnCallFloor2Down";
            this.btnCallFloor2Down.Size = new System.Drawing.Size(135, 32);
            this.btnCallFloor2Down.TabIndex = 21;
            this.btnCallFloor2Down.Text = "FLOOR 2 ▼ DOWN";
            this.btnCallFloor2Down.UseVisualStyleBackColor = false;
            this.btnCallFloor2Down.Click += new System.EventHandler(this.btnCallFloor2Down_Click);
            // 
            // btnCallFloor1Down
            // 
            this.btnCallFloor1Down.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCallFloor1Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCallFloor1Down.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallFloor1Down.ForeColor = System.Drawing.Color.Black;
            this.btnCallFloor1Down.Location = new System.Drawing.Point(10, 65);
            this.btnCallFloor1Down.Name = "btnCallFloor1Down";
            this.btnCallFloor1Down.Size = new System.Drawing.Size(135, 32);
            this.btnCallFloor1Down.TabIndex = 20;
            this.btnCallFloor1Down.Text = "FLOOR 1 ▼ DOWN";
            this.btnCallFloor1Down.UseVisualStyleBackColor = false;
            this.btnCallFloor1Down.Click += new System.EventHandler(this.btnCallFloor1Down_Click);
            // 
            // btnCallFloor1Up
            // 
            this.btnCallFloor1Up.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCallFloor1Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCallFloor1Up.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallFloor1Up.ForeColor = System.Drawing.Color.Black;
            this.btnCallFloor1Up.Location = new System.Drawing.Point(165, 25);
            this.btnCallFloor1Up.Name = "btnCallFloor1Up";
            this.btnCallFloor1Up.Size = new System.Drawing.Size(135, 32);
            this.btnCallFloor1Up.TabIndex = 19;
            this.btnCallFloor1Up.Text = "FLOOR 1 ▲ UP";
            this.btnCallFloor1Up.UseVisualStyleBackColor = false;
            this.btnCallFloor1Up.Click += new System.EventHandler(this.btnCallFloor1Up_Click);
            // 
            // btnCallGroundUp
            // 
            this.btnCallGroundUp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCallGroundUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCallGroundUp.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallGroundUp.ForeColor = System.Drawing.Color.Black;
            this.btnCallGroundUp.Location = new System.Drawing.Point(10, 25);
            this.btnCallGroundUp.Name = "btnCallGroundUp";
            this.btnCallGroundUp.Size = new System.Drawing.Size(135, 32);
            this.btnCallGroundUp.TabIndex = 18;
            this.btnCallGroundUp.Text = "GROUND ▲ UP";
            this.btnCallGroundUp.UseVisualStyleBackColor = false;
            this.btnCallGroundUp.Click += new System.EventHandler(this.btnCallGroundUp_Click);
            // 
            // lblMonitoringTitle
            // 
            this.lblMonitoringTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.lblMonitoringTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMonitoringTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitoringTitle.Location = new System.Drawing.Point(0, 0);
            this.lblMonitoringTitle.Name = "lblMonitoringTitle";
            this.lblMonitoringTitle.Size = new System.Drawing.Size(350, 45);
            this.lblMonitoringTitle.TabIndex = 16;
            this.lblMonitoringTitle.Text = "SYSTEM MONITORING";
            this.lblMonitoringTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmergencyValue
            // 
            this.lblEmergencyValue.BackColor = System.Drawing.Color.LightGreen;
            this.lblEmergencyValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmergencyValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEmergencyValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyValue.ForeColor = System.Drawing.Color.Green;
            this.lblEmergencyValue.Location = new System.Drawing.Point(10, 353);
            this.lblEmergencyValue.Name = "lblEmergencyValue";
            this.lblEmergencyValue.Size = new System.Drawing.Size(180, 48);
            this.lblEmergencyValue.TabIndex = 14;
            this.lblEmergencyValue.Text = "NORMAL";
            this.lblEmergencyValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmergencyStatus
            // 
            this.lblEmergencyStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyStatus.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblEmergencyStatus.Location = new System.Drawing.Point(10, 320);
            this.lblEmergencyStatus.Name = "lblEmergencyStatus";
            this.lblEmergencyStatus.Size = new System.Drawing.Size(180, 35);
            this.lblEmergencyStatus.TabIndex = 13;
            this.lblEmergencyStatus.Text = "EMERGENCY STATUS";
            this.lblEmergencyStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDirectionValue
            // 
            this.lblDirectionValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectionValue.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDirectionValue.Location = new System.Drawing.Point(180, 260);
            this.lblDirectionValue.Name = "lblDirectionValue";
            this.lblDirectionValue.Size = new System.Drawing.Size(125, 35);
            this.lblDirectionValue.TabIndex = 12;
            this.lblDirectionValue.Text = "STOPPED";
            this.lblDirectionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDirection
            // 
            this.lblDirection.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDirection.Location = new System.Drawing.Point(10, 260);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(110, 35);
            this.lblDirection.TabIndex = 11;
            this.lblDirection.Text = "DIRECTION";
            this.lblDirection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoorValue
            // 
            this.lblDoorValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoorValue.ForeColor = System.Drawing.Color.Red;
            this.lblDoorValue.Location = new System.Drawing.Point(180, 200);
            this.lblDoorValue.Name = "lblDoorValue";
            this.lblDoorValue.Size = new System.Drawing.Size(125, 35);
            this.lblDoorValue.TabIndex = 10;
            this.lblDoorValue.Text = "CLOSED";
            this.lblDoorValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoorStatus
            // 
            this.lblDoorStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoorStatus.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDoorStatus.Location = new System.Drawing.Point(10, 200);
            this.lblDoorStatus.Name = "lblDoorStatus";
            this.lblDoorStatus.Size = new System.Drawing.Size(141, 35);
            this.lblDoorStatus.TabIndex = 9;
            this.lblDoorStatus.Text = "DOOR STATUS";
            this.lblDoorStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMotorValue
            // 
            this.lblMotorValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorValue.ForeColor = System.Drawing.Color.Red;
            this.lblMotorValue.Location = new System.Drawing.Point(180, 140);
            this.lblMotorValue.Name = "lblMotorValue";
            this.lblMotorValue.Size = new System.Drawing.Size(125, 35);
            this.lblMotorValue.TabIndex = 4;
            this.lblMotorValue.Text = "STOPPED";
            this.lblMotorValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMotorValue.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMotorStatus
            // 
            this.lblMotorStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorStatus.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMotorStatus.Location = new System.Drawing.Point(10, 140);
            this.lblMotorStatus.Name = "lblMotorStatus";
            this.lblMotorStatus.Size = new System.Drawing.Size(221, 35);
            this.lblMotorStatus.TabIndex = 8;
            this.lblMotorStatus.Text = "MOTOR STATUS";
            this.lblMotorStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlControls.Controls.Add(this.lblFloor0);
            this.pnlControls.Controls.Add(this.lblFloor1);
            this.pnlControls.Controls.Add(this.pnlShaft);
            this.pnlControls.Controls.Add(this.lblFloor2);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Controls.Add(this.lblElevatorTitle);
            this.pnlControls.Location = new System.Drawing.Point(425, 100);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(350, 550);
            this.pnlControls.TabIndex = 2;
            // 
            // lblFloor0
            // 
            this.lblFloor0.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloor0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFloor0.Location = new System.Drawing.Point(230, 410);
            this.lblFloor0.Name = "lblFloor0";
            this.lblFloor0.Size = new System.Drawing.Size(110, 35);
            this.lblFloor0.TabIndex = 6;
            this.lblFloor0.Text = "FLOOR 0";
            this.lblFloor0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFloor1
            // 
            this.lblFloor1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloor1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFloor1.Location = new System.Drawing.Point(230, 278);
            this.lblFloor1.Name = "lblFloor1";
            this.lblFloor1.Size = new System.Drawing.Size(110, 35);
            this.lblFloor1.TabIndex = 5;
            this.lblFloor1.Text = "FLOOR 1";
            this.lblFloor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlShaft
            // 
            this.pnlShaft.BackColor = System.Drawing.Color.White;
            this.pnlShaft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlShaft.Controls.Add(this.pnlCabin);
            this.pnlShaft.Controls.Add(this.lblFloorValue);
            this.pnlShaft.Controls.Add(this.lblCurrentFloor);
            this.pnlShaft.Location = new System.Drawing.Point(10, 70);
            this.pnlShaft.Name = "pnlShaft";
            this.pnlShaft.Size = new System.Drawing.Size(214, 400);
            this.pnlShaft.TabIndex = 2;
            this.pnlShaft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShaft_Paint);
            // 
            // pnlCabin
            // 
            this.pnlCabin.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlCabin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCabin.Controls.Add(this.lblCabin);
            this.pnlCabin.Location = new System.Drawing.Point(7, 327);
            this.pnlCabin.Name = "pnlCabin";
            this.pnlCabin.Size = new System.Drawing.Size(180, 65);
            this.pnlCabin.TabIndex = 9;
            // 
            // lblCabin
            // 
            this.lblCabin.AutoSize = true;
            this.lblCabin.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCabin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCabin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabin.Location = new System.Drawing.Point(0, 0);
            this.lblCabin.Name = "lblCabin";
            this.lblCabin.Size = new System.Drawing.Size(91, 23);
            this.lblCabin.TabIndex = 1;
            this.lblCabin.Text = "ELEVATOR";
            this.lblCabin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFloorValue
            // 
            this.lblFloorValue.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFloorValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblFloorValue.Location = new System.Drawing.Point(130, 1);
            this.lblFloorValue.Name = "lblFloorValue";
            this.lblFloorValue.Size = new System.Drawing.Size(89, 34);
            this.lblFloorValue.TabIndex = 3;
            this.lblFloorValue.Text = "FLOOR 0";
            this.lblFloorValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentFloor
            // 
            this.lblCurrentFloor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFloor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCurrentFloor.Location = new System.Drawing.Point(-1, 1);
            this.lblCurrentFloor.Name = "lblCurrentFloor";
            this.lblCurrentFloor.Size = new System.Drawing.Size(140, 36);
            this.lblCurrentFloor.TabIndex = 2;
            this.lblCurrentFloor.Text = "CURRENT FLOOR";
            this.lblCurrentFloor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFloor2
            // 
            this.lblFloor2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFloor2.Location = new System.Drawing.Point(225, 141);
            this.lblFloor2.Name = "lblFloor2";
            this.lblFloor2.Size = new System.Drawing.Size(110, 35);
            this.lblFloor2.TabIndex = 4;
            this.lblFloor2.Text = "FLOOR 2";
            this.lblFloor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFloor2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblElevatorTitle
            // 
            this.lblElevatorTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.lblElevatorTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblElevatorTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElevatorTitle.Location = new System.Drawing.Point(0, 0);
            this.lblElevatorTitle.Name = "lblElevatorTitle";
            this.lblElevatorTitle.Size = new System.Drawing.Size(350, 45);
            this.lblElevatorTitle.TabIndex = 0;
            this.lblElevatorTitle.Text = "ELEVATOR VISUALIZATION";
            this.lblElevatorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMonitoring
            // 
            this.pnlMonitoring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.pnlMonitoring.Controls.Add(this.btnEmergency);
            this.pnlMonitoring.Controls.Add(this.btnCloseDoor);
            this.pnlMonitoring.Controls.Add(this.btnOpenDoor);
            this.pnlMonitoring.Controls.Add(this.btnFloor2);
            this.pnlMonitoring.Controls.Add(this.btnFloor1);
            this.pnlMonitoring.Controls.Add(this.btnFloor0);
            this.pnlMonitoring.Controls.Add(this.lblControlsTitle);
            this.pnlMonitoring.Location = new System.Drawing.Point(800, 100);
            this.pnlMonitoring.Name = "pnlMonitoring";
            this.pnlMonitoring.Size = new System.Drawing.Size(350, 550);
            this.pnlMonitoring.TabIndex = 3;
            // 
            // btnEmergency
            // 
            this.btnEmergency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEmergency.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmergency.Location = new System.Drawing.Point(35, 480);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(280, 50);
            this.btnEmergency.TabIndex = 8;
            this.btnEmergency.Text = "⚠ EMERGENCY STOP";
            this.btnEmergency.UseVisualStyleBackColor = false;
            this.btnEmergency.Click += new System.EventHandler(this.btnEmergency_Click);
            // 
            // btnCloseDoor
            // 
            this.btnCloseDoor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCloseDoor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseDoor.Location = new System.Drawing.Point(185, 410);
            this.btnCloseDoor.Name = "btnCloseDoor";
            this.btnCloseDoor.Size = new System.Drawing.Size(130, 50);
            this.btnCloseDoor.TabIndex = 7;
            this.btnCloseDoor.Text = "CLOSE DOOR";
            this.btnCloseDoor.UseVisualStyleBackColor = false;
            this.btnCloseDoor.Click += new System.EventHandler(this.btnCloseDoor_Click);
            // 
            // btnOpenDoor
            // 
            this.btnOpenDoor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnOpenDoor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDoor.Location = new System.Drawing.Point(35, 410);
            this.btnOpenDoor.Name = "btnOpenDoor";
            this.btnOpenDoor.Size = new System.Drawing.Size(130, 50);
            this.btnOpenDoor.TabIndex = 6;
            this.btnOpenDoor.Text = "OPEN DOOR";
            this.btnOpenDoor.UseVisualStyleBackColor = false;
            this.btnOpenDoor.Click += new System.EventHandler(this.btnOpenDoor_Click);
            // 
            // btnFloor2
            // 
            this.btnFloor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFloor2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloor2.Location = new System.Drawing.Point(100, 250);
            this.btnFloor2.Name = "btnFloor2";
            this.btnFloor2.Size = new System.Drawing.Size(150, 50);
            this.btnFloor2.TabIndex = 3;
            this.btnFloor2.Text = "FLOOR 2";
            this.btnFloor2.UseVisualStyleBackColor = false;
            this.btnFloor2.Click += new System.EventHandler(this.btnFloor2_Click);
            // 
            // btnFloor1
            // 
            this.btnFloor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFloor1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloor1.Location = new System.Drawing.Point(100, 180);
            this.btnFloor1.Name = "btnFloor1";
            this.btnFloor1.Size = new System.Drawing.Size(150, 50);
            this.btnFloor1.TabIndex = 2;
            this.btnFloor1.Text = "FLOOR 1";
            this.btnFloor1.UseVisualStyleBackColor = false;
            this.btnFloor1.Click += new System.EventHandler(this.btnFloor1_Click);
            // 
            // btnFloor0
            // 
            this.btnFloor0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFloor0.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloor0.Location = new System.Drawing.Point(100, 110);
            this.btnFloor0.Name = "btnFloor0";
            this.btnFloor0.Size = new System.Drawing.Size(150, 50);
            this.btnFloor0.TabIndex = 1;
            this.btnFloor0.Text = "GROUND FLOOR";
            this.btnFloor0.UseVisualStyleBackColor = false;
            this.btnFloor0.Click += new System.EventHandler(this.btnFloor0_Click);
            // 
            // lblControlsTitle
            // 
            this.lblControlsTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.lblControlsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblControlsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblControlsTitle.Name = "lblControlsTitle";
            this.lblControlsTitle.Size = new System.Drawing.Size(350, 45);
            this.lblControlsTitle.TabIndex = 0;
            this.lblControlsTitle.Text = "ELEVATOR CONTROLS";
            // 
            // ElevatorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.pnlMonitoring);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlElevator);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ElevatorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMART ELEVATOR CONTROL SYSTEM";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlElevator.ResumeLayout(false);
            this.grpHallCall.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlShaft.ResumeLayout(false);
            this.pnlCabin.ResumeLayout(false);
            this.pnlCabin.PerformLayout();
            this.pnlMonitoring.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlElevator;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlMonitoring;
        private System.Windows.Forms.Label lblElevatorTitle;
        private System.Windows.Forms.Panel pnlShaft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFloor2;
        private System.Windows.Forms.Label lblFloor0;
        private System.Windows.Forms.Label lblFloor1;
        private System.Windows.Forms.Label lblControlsTitle;
        private System.Windows.Forms.Button btnFloor0;
        private System.Windows.Forms.Button btnFloor2;
        private System.Windows.Forms.Button btnFloor1;
        private System.Windows.Forms.Button btnOpenDoor;
        private System.Windows.Forms.Button btnCloseDoor;
        private System.Windows.Forms.Button btnEmergency;
        private System.Windows.Forms.Label lblCurrentFloor;
        private System.Windows.Forms.Label lblFloorValue;
        private System.Windows.Forms.Label lblMotorStatus;
        private System.Windows.Forms.Label lblMotorValue;
        private System.Windows.Forms.Label lblDoorStatus;
        private System.Windows.Forms.Label lblDoorValue;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblDirectionValue;
        private System.Windows.Forms.Label lblEmergencyValue;
        private System.Windows.Forms.Label lblEmergencyStatus;
        private System.Windows.Forms.Panel pnlCabin;
        private System.Windows.Forms.Label lblCabin;
        private System.Windows.Forms.Label lblMonitoringTitle;
        private System.Windows.Forms.GroupBox grpHallCall;
        private System.Windows.Forms.Button btnCallGroundUp;
        private System.Windows.Forms.Button btnCallFloor2Down;
        private System.Windows.Forms.Button btnCallFloor1Down;
        private System.Windows.Forms.Button btnCallFloor1Up;
        private System.Windows.Forms.Button btnObstacle;
        private System.Windows.Forms.Label lblDirectionArrow;
    }
}

