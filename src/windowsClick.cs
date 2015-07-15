/*---------------------------------------------------------------------------------------------------------------------------------------
 * Name:          Windows Click
 * Author:        Tyler aka Link aka Zafar
 *
 * Description:
 * Some windows click handling, primarely where the mouse is, and allowing it be moved and clicked elsewhere
 * 
 * 
 * Version History
 * v1.0 on 5/19/2015 : Split from my "Open Divine Gifts" program, which was then renamed to "Interval Click"
 * v1.1 on 5/19/2015 : Changed slightly for graphic version of Interval Click     
 * v1.2 on 6/11/2015 : Changed Sleep to be an incremental variable to enable displaying time until next click
 * v1.3 on 6/11/2015 : Reposition mouse between double clicks, allow left and right click togehter, instead of one or the other
 *                      The function was already there, but because it was an else if instead of an if, it was disabled
 * v1.4 on 6/11/2015 : Heavy rewrite of how clicking works; instead of click up and click down as one event, it calls it as one now, change x/y handling to Point instead of individual int's
 * 
 * Compile Note: Requires adding "System.Drawing" and "System.Windows.Forms" to resources if not already present
 * --------------------------------------------------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Runtime.InteropServices;

namespace Interval_Click_Graphic
{
    /// <summary>
    /// Handle windows side of click logic
    /// </summary>
    class windowsClick
    {
        public static double TimeSinceClick = 0;

        /// <summary>
        /// Reports current mouse location back to caller
        /// </summary>
        /// <param name="x">value of cursor's x at time of input</param>
        /// <param name="y">value of cursor's y at time of input</param>
        public static void currentMouseLocation(ref Point p)
        {
            // Current Mouse Loc
            p = Cursor.Position;
        }

        /// <summary>
        /// Clicks every x minutes until thread is killed
        /// </summary>
        /// <param name="xPos">Where to click</param>
        /// <param name="yPos">Where to click</param>
        /// <param name="button">Which button to click (0 for left, 1 for right)</param>
        /// <param name="interval">How often in minutes to click</param>
        public static void clickInterval(Point p, int button, double interval, bool doubleClick)
        {
            while (true)
            {
                click(p, button, doubleClick);

                while (TimeSinceClick < interval)
                {
                    Thread.Sleep((int)(100));
                    TimeSinceClick += .0016666; // 1000 ms per second, 60 seconds per minute (100 ms is roughly .0016666)
                }

                TimeSinceClick = 0;
            }
        }


        #region Dll declaration and enums for mouse button usage
        /// <summary>
        ///  Imports required DLL and allows you to simulate mouse buttons
        /// </summary>
        /// <param name="dwFlags">Flags to send</param>
        /// <param name="dx">If ABSOLUTE or MOVE flags are set, move mouse to said x position; doesn't seem to work correctly though</param>
        /// <param name="dy">If ABSOLUTE or MOVE flags are set, move mouse to said y position; doesn't seem to work correctly though</param>
        /// <param name="dwData">returns info based on what flag's provided, see https://msdn.microsoft.com/en-us/library/windows/desktop/ms646260(v=vs.85).aspx </param>
        /// <param name="dwExtraInfo">Extra info, normally unneeded</param>
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        /// <summary>
        ///  Flags for mouse_event
        /// </summary>
        class mouseeventflags
        {
            public const uint ABSOLUTE = 0x8000,
            LEFTDOWN = 0x0002,
            LEFTUP = 0x0004,
            MIDDLEDOWN = 0x0020,
            MIDDLEUP = 0x0040,
            MOVE = 0x0001,
            RIGHTDOWN = 0x0008,
            RIGHTUP = 0x0010,
            XDOWN = 0x0080,
            XUP = 0x0100,
            WHEEL = 0x0800,
            HWHEEL = 0x01000;
        }
        #endregion


        /// <summary>
        /// Moves mouse to location, then left or right clicks twice (once to enter window, once to activate...maybe modify it to only click ones later)
        /// </summary>
        /// <param name="x">Position to move x part of cursor to</param>
        /// <param name="y">Position to move y part of cursor to</param>
        /// <param name="button">0 or 1 or 3, for left or right, or both</param>
        public static void click(Point p, int button, bool doubleClick)
        {
            
            // Clicks once to enter window, once to click for real; should do it fast enough to not be interpreted as a double click
            // using windows normal double click timeframe (500 ms) (from http://ux.stackexchange.com/questions/40364/what-is-the-expected-timeframe-of-a-double-click)
            Cursor.Position = p;
            if (button == 0 || button == 3)
            {
                mouse_event(mouseeventflags.LEFTDOWN | mouseeventflags.LEFTUP, 0, 0, 0, 0);

                if (doubleClick)
                {
                    Thread.Sleep(100);
                    Cursor.Position = p;
                    mouse_event(mouseeventflags.LEFTDOWN | mouseeventflags.LEFTUP, 0, 0, 0, 0);
                }
            }
            if (button == 1 || button == 3)
            {
                mouse_event(mouseeventflags.RIGHTDOWN | mouseeventflags.RIGHTUP, 0, 0, 0, 0);

                if (doubleClick)
                {
                    Thread.Sleep(100);
                    Cursor.Position = p;
                    mouse_event(mouseeventflags.RIGHTDOWN | mouseeventflags.RIGHTUP, 0, 0, 0, 0);
                }
            }
        }
    }
}