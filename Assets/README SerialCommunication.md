
\
Welcome to the Unity Arduino Template project.\
\
This project is pre-configured to safely communicate between Unity and Arduino using the SerialPortManager system.\
\
---\
\
## IMPORTANT FIRST STEP\
\
Before pressing Play:\
\
1. Change project settings before or immediately after importing package:\
	Menu <Edit><Project Settings>\
	<player><other settings><API Compatibility Level*> .NET Framework\
2. Select the GameObject "SerialManager"\
3. In the Inspector:\
   - Set the correct Serial Port (COM port on Windows, /dev/... on Mac)\
   - Make sure baudrate matches Arduino (default: 9600)\
\
---\
\
## How This Project Works\
\
All serial communication is handled through:\
\
SerialPortManager.cs\
\
DO NOT directly access SerialPort from other scripts !!!\
\
To get access in other scripts to the SerialPortManager, add this code in your script:\
    private SerialPortManager spManager; // Get access to the serialport defined in the SerialPortManager\
\
To send data to the serial port:\
    spManager.SendSafe(messageToSerial);\
\
To read data from the serial port:\
    spManager.TryReadLine(out string value);\
\
---\
\
## Student Workflow\
\
1. Create your scripts inside:\
   Assets/_StudentsWorkHere/\
\
2. Use an modify:\
   - SendToSerialOnWhenever\
   - ReadSerial\
\
3. Modify only what is necessary.\
\
---\
\
## Common Errors\
\
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f1 \cf0 \uc0\u10060 
\f0  Serial port not found  \

\f2 \uc0\u8594 
\f0  Check correct COM port\
\

\f1 \uc0\u10060 
\f0  Nothing happens  \

\f2 \uc0\u8594 
\f0  Check if Arduino prints "READY"\
\

\f1 \uc0\u10060 
\f0  Unity freezes  \

\f2 \uc0\u8594 
\f0  Do not use ReadLine() in Update()\
\
---\
\
Good luck and have fun!}