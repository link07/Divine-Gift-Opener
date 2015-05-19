# Interval Click
Program I created a while back to open Archeage Divine Gifts, I eventually tacked on the 'feature' of left or right clicking anywhere on screen every x minutes on Windows.
On 5/19/2015 I renamed it from "Divine Gift Opener" to "Interval Click", and reworked the code to follow that more, split into a console and graphic version, and started a c# form for it
So far the graphic version has less features, but the features it does have are easier to use

Used heavily on Windows 7

Tested a bit on Windows 8, though it seems to not always interpret clicks in 8 (This could be the laptop I was using)

# Compile Notes - For Console Version
Create Visual Studio (2013) C# Console Program
Add both files
Include "System.Drawing" and "System.Windows.Forms" from the resources folder
Also include optional icon

#Compile Notes - For Graphic Version
Create Visual Studio (2013) C# Form Program
Add all files
