{\rtf1\ansi\ansicpg1252\cocoartf2822
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f0\fs24 \cf0 # Unity & Arduino Serial Communication Template\
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
1. Select the GameObject "SerialManager"\
2. In the Inspector:\
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
DO NOT directly access SerialPort from other scripts.\
\
To send data:\
    spManager.Send("A");\
\
To read data:\
    spManager.TryReadLine(out string value);\
\
---\
\
## Student Workflow\
\
1. Create your scripts inside:\
   Assets/_StudentsWorkHere/\
\
2. Use:\
   - SendToSerialOnWhenever\
   - SendToSerialOnCollision\
   - ReadSerial\
\
3. Modify only what is necessary.\
\
---\
\
## Common Errors\
\
\uc0\u10060  Serial port not found  \
\uc0\u8594  Check correct COM port\
\
\uc0\u10060  Nothing happens  \
\uc0\u8594  Check if Arduino prints "READY"\
\
\uc0\u10060  Unity freezes  \
\uc0\u8594  Do not use ReadLine() in Update()\
\
---\
\
Good luck and have fun!}