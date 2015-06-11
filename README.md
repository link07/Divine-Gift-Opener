# Interval Click
Program I created a while back to open Archeage Divine Gifts, I eventually tacked on the 'feature' of left or right clicking anywhere on screen every x minutes on Windows.

On 5/19/2015 I renamed it from "Divine Gift Opener" to "Interval Click", and reworked the code to allow more customizability, split into a console and graphic version.

The console version technically has more features, but as of 6/11/2015 I consider them to have feature parity, even if the console version has more options in its menu.

# Testing information
Used heavily on Windows 7

Tested a bit on Windows 8.  Back in v1.1 of the Console version, it seemed to not always interpret the clicks in windows 8.  I believe this was just the laptop I was using to test it, and have not tested it since that early version.

# Compile Notes - For Console Version
Create Visual Studio (2013) C# Console Program
Add both files

Include "System.Drawing" and "System.Windows.Forms" from the resources folder

Also include optional icon

#Compile Notes - For Graphic Version
Create Visual Studio (2013) C# Form Program

Add all files

Add info in the application assembly information, add icon, build it