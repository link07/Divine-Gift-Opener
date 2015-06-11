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
    public class threadHandler
    {
        private bool running = false;
        private Thread clickIntervalThread;

        /// <summary>
        /// Starts click thread
        /// </summary>
        /// <param name="xPicked">x to move cursor to</param>
        /// <param name="yPicked">y to move curosr to</param>
        /// <param name="mouse">mouse to click</param>
        /// <param name="time">interval between clicks</param>
        public void startThread(int xPicked, int yPicked, int mouse, double time)
        {
           // Create thread with multiple variables being passed (original found in credits)
            clickIntervalThread = new Thread(() => windowsClick.clickInterval(xPicked, yPicked, mouse, time));

            // Start Thread
            clickIntervalThread.Start();
            running = true;
        }


        /// <summary>
        /// if thread is running, exit it
        /// </summary>
        public void exitThread()
        {
            if (running)
                clickIntervalThread.Abort();
        }
    }
}