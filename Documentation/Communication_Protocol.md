# TCP/IP Communication Protocol

## Topology

| Item | Value |
|---|---|
| Server | LabVIEW (listener initialized when the VI starts) |
| Client | C# Windows Forms dashboard |
| Address | `127.0.0.1` |
| Port | `5000` |
| Mode | Bidirectional, plain-text messages |

## Execution sequence

1. The LabVIEW TCP server initializes and listens on port 5000.
2. LabVIEW launches the C# dashboard (`System Exec.vi`, non-blocking).
3. The C# application connects to the LabVIEW TCP server.
4. The user interacts with the dashboard.
5. C# sends elevator commands to LabVIEW.
6. LabVIEW processes the requests through its state machine.
7. LabVIEW transmits elevator status information to C#.
8. The dashboard updates its visual representation from the received status.

## C# → LabVIEW: commands

| Command | Function |
|---|---|
| `0` | Request ground floor |
| `1` | Request first floor |
| `2` | Request second floor |
| `E` | Emergency stop |
| `R` | Reset |

LabVIEW reads the commands with *TCP Read* and converts them into elevator control requests, which are combined with the existing physical-button logic of the state machine.

## LabVIEW → C#: status message

Seven comma-separated values:

```
Position,Destination,Motor,Direction,DoorOpen,Alarm,Locked
```

| Field | Meaning |
|---|---|
| Position | Current floor (0 to 2) |
| Destination | Requested destination floor |
| Motor | Motor operating status |
| Direction | `0` stopped, `1` up, `2` down |
| DoorOpen | Door-open status |
| Alarm | Emergency alarm status |
| Locked | System lock status |

Built with *Format Into String* and sent with *TCP Write*. The C# application parses the values and updates the dashboard.

## Connection handling (LabVIEW side)

- TCP listener initialization
- Client connection management
- Connection ID kept in shift registers
- Connection validation
- Timeout handling
- Detection of connection errors
- Closing and resetting the connection after a disconnection
