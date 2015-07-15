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
 * --------------------------------------------------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Interval_Click_Graphic
{
    /// <summary>
    /// Handles logic for click thread
    /// </summary>
    public class clickThreadHandler
    {
        /// <summary>
        /// True if click thread is running, false if not 
        /// </summary>
        public static bool isRunning = false;

        /// <summary>
        /// Click thread
        /// </summary>
        private Thread clickIntervalThread;

        /// <summary>
        /// Starts click thread
        /// </summary>
        /// <param name="xPicked">x to move cursor to</param>
        /// <param name="yPicked">y to move curosr to</param>
        /// <param name="mouse">mouse to click</param>
        /// <param name="time">interval between clicks</param>
        public void startThread(int xPicked, int yPicked, int mouse, double time, bool doubleClick)
        {
           // Create thread with multiple variables being passed (original found in credits)
            clickIntervalThread = new Thread(() => windowsClick.clickInterval(xPicked, yPicked, mouse, time, doubleClick));

            // Start Thread
            clickIntervalThread.Start();
            isRunning = true;
        }


        /// <summary>
        /// if thread is running, exit it
        /// </summary>
        public void exitThread()
        {
            if (isRunning == true)
            {
                clickIntervalThread.Abort();

                isRunning = false;

                windowsClick.TimeSinceClick = 0;

            }
        }
    }
}