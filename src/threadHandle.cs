/*---------------------------------------------------------------------------------------------------------------------------------------
 * Name:          Click Handler
 * Author:        Tyler aka Link aka Zafar
 *
 * Description:
 * Handles threading for windowsClick
 * 
 * 
 * Version History:
 * v1.0 on 5/19/2015 : Split from Interval Click for graphic version
 * v1.1 on 6/11/2015 : class change (threadeHandler to clickThreadHandler) in order to allow future additions
 * v1.1.1 on 6/11/2015 : Update function calls to windowsClick
 * v1.2 on 6/11/2015 : Add System.Drawing, change from int x,y to point p
 * --------------------------------------------------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace Interval_Click_Graphic
{
    /// <summary>
    /// Handles logic for click thread
    /// </summary>
    public class clickThreadHandler
    {
        /// <summary>
        /// True if click thread is running, false if not; provides a cleaner way to check if thread.IsAlive; as that will crash the program if thread is yet to be initilized
        /// </summary>
        public static bool isRunning = false;

        /// <summary>
        /// Create instance of click thread
        /// </summary>
        private Thread clickIntervalThread;

        /// <summary>
        /// Starts click thread
        /// </summary>
        /// <param name="p">Point to move mouse to when clicking</param>
        /// <param name="mouse">mouse to click</param>
        /// <param name="time">interval between clicks</param>
        /// <param name="doubleClick">To doubleclick or not</param>
        public void startThread(Point p, int mouse, double time, bool doubleClick)
        {
           // Create thread with multiple variables being passed (original found in credits)
            clickIntervalThread = new Thread(() => windowsClick.clickInterval(p, mouse, time, doubleClick));

            // Start Thread
            clickIntervalThread.Start();
            isRunning = true;
        }


        /// <summary>
        /// if thread is running, exit it
        /// </summary>
        public void exitThread()
        {
            if (isRunning)
            {
                clickIntervalThread.Abort();

                isRunning = false;

                windowsClick.TimeSinceClick = 0;
            }
        }
    }
}