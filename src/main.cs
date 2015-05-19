/*---------------------------------------------------------------------------------------------------------------------------------------
 * Program:       Divine Gift Opener v 2.0.3
 * Author:        Tyler aka Link aka Zafar
 *
 * Description:
 * Auto Collects Archage Divine Gifts every 15 mins, to be used primary when afk'ing
 * 
 * Note, v2.0 was originally called v 1.2, v2.0.1 was, v1.2.1, v2.0.2 was v1.2.2, v2.0.3 was start of offical v2
 * 
 * Version History:
 * v2.1     on 5/19/15  : Split into two files to allow extrapolating from the pogram easier, rename to interval click
 * v2.0.4.1 on 5/10/15  : Minor code cleanup, post to GitHub
 * v2.0.4   on 1/30/15  : Fix minor menu issue
 * v2.0.3   on 1/29/15  : Double click did not fix issue, add 248 ms wait time before mousedown and mouse, 
 *                        seems to work correctly (likely 1/28/15 downtime "fixed" this issue, but there was no patch notes or client update)
 * v2.0.2   on 1/29/15  : Double click, first click to enter window, second click to activate button (add option for single click later) 
 *                        (also added many comments, and started testing console color)
 * v2.0.1   on 1/28/15  : Fix outputs, make it a published exe file
 * v2.0     on 1/28/15  : almost complete rewrite, able to pass multiple values to thread, so can completly customize location / mouse clicked
 *                        no longer really archeage gift opener, more general clicker; also a heavy rewrite of the menu, possible errors
 * v1.1     on 1/24/15  : added multi monitor support and menu (along with a semi-major redisign of major functions)
 * V1.0     on 1/23/15  : First version, copied code from my own application for AFK'ing in archeage (that I never actually got to work, hitting scarecrows is easier lol)
 *                        Which had code copied from Barnacle's Codegasm 
 *                  
 * Compile Note: Requires manually adding "System.Drawing" and "System.Windows.Forms"
 * --------------------------------------------------------------------------------------------------------------------------------------*/

/*-------------------------------------------------------------------
 * Credits: 
 * http://stackoverflow.com/questions/3360555/how-to-pass-parameters-to-threadstart-method-in-thread how to use objects
 * Barnacles' drunk pc app walkthrough for threading and mouse movement
 * **Find link later** for left / right click control
 * Multiple values passed to a thread, http://stackoverflow.com/a/2490295
 * Regex until exit, http://stackoverflow.com/a/1181426
 * ------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Added
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Text.RegularExpressions;
using windowsClick;

/// Based on my own Anti-Archage AFK app, which was based on Barnacules' Drunk PC prank code
/// Blocks you from going AFK, including with smart afk detectors (e.g. archeage)
/// Created by Link / Zafar
/// Created on 1/23/2015

namespace divineGiftOpener
{
    class Program
    {
        // Position of box on the main 1080p monitor X: 28, Y: 984


        /// <summary>
        /// Entry point for Divine Gift Openerd
        /// </summary>
        /// <param name="return">0 successful run and exit</param>
        /// <param name="return">1 exit before threadstart</param>
        #region Main
        [STAThread]
        static int Main()
        {
            // Set Title of Console /// Try to find a better way?
            Console.Title = "Zafar's Divine Gift Collector v2.0.3";

            // Setup variables
            const int xDefault = 28, yDefault = 984; // Default spot of divine gift button for 1080p screen
            int xPicked = xDefault, yPicked = yDefault, mouse = 0; // Allow x and y to be changed without modifying everything else, and mouse button to press
            double time = 15; // How long between intervals, in minutes
            bool cont = false, exit = false; // Continue the program, or exit the program

            // Intro + open program
            Console.WriteLine("Divine Gift Opener v2.0.3 written by: Zafar / Link");
            Console.WriteLine("");
            Console.WriteLine("Primarily for opening divine gifts in archeage in 1080p,");
            Console.WriteLine("but it can be customized to do other things");

            // Menu
            while (!cont && !exit)
            {
                cont = genMenu(ref exit, ref xPicked, ref yPicked, ref mouse, ref time);
            }

            // Exit program if Menu asked for exit
            if (exit)
            {
                return 1;
            }



            // Create thread with multiple variables being passed (original found in credits)
            Thread clickIntervalThread = new Thread(() => windowsClick.windowsClick.clickInterval(xPicked, yPicked, mouse, time));

            // Start Thread
            clickIntervalThread.Start();

            // Exit program
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            textColor(0);
            Console.Write("Enter any Letter or Number to exit: ");
            textColor(-1);


            while (!exit)
            {
                if (Regex.IsMatch(Convert.ToString(Console.ReadLine()), @"^[a-zA-Z0-9_]+$"))
                {
                    exit = true;
                    clickIntervalThread.Abort();
                    return 0;
                }
            }

            return 0;
        }
        #endregion


        #region genMenu
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exit">true if program should exit, false if not</param>
        /// <param name="x">cursor's x value to be used</param>
        /// <param name="y">cursor's y value to be used</param>
        /// <param name="mouse">0 for left button, 1 for right</param>
        /// <param name="time">How often to click, sent in minutes</param>
        /// <returns>true if program can continue, false if not</returns>
        static bool genMenu(ref bool exit, ref int x, ref int y, ref int mouse, ref double time)
        {
            int nextMenu = 0;
            bool cont = false;
            int monChoice = 1;
            int settMenuChoice = 0, xDefault = x, yDefault = y;
            while (!cont && !exit)
            {
                // Generate Menu + get choice (based on last choice)
                if (nextMenu == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Enter 1 to continue.");
                    Console.WriteLine("Enter 2 to change settings.");
                    Console.WriteLine("Enter 5 to exit program.");
                    Console.Write("Input: ");

                    nextMenu = Convert.ToInt32(Console.ReadLine());
                    
                    switch (nextMenu)
                    {
                        case 1: cont = true;
                            break;
                        case 2:
                            break;
                        case 5: exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice.");
                            nextMenu = 0;
                            break;
                    }
                }
                else if (nextMenu == 2)
                {
                    #region if
                    if (settMenuChoice == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Enter 1 for 1080p monitor choice, 2 for manual location select.");
                        Console.WriteLine("3 for mouse button select (default left), 4 for Interval Select");
                        Console.WriteLine("Enter 5 for Main Menu");

                        settMenuChoice = Convert.ToInt32(Console.ReadLine());
                        if (settMenuChoice == 5)
                        {
                            nextMenu = 0;
                        }
                    }
                    switch (settMenuChoice)
                    {
                        #region settMenuChoice
                        case 1:
                            #region monChoice
                            Console.WriteLine("Enter 1 for Centor Monitor, 2 for Left Monitor, and 3 for Right Monitor.");
                            Console.WriteLine("Enter 5 for Settings Menu.");
                            Console.Write("Input: ");

                            monChoice = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("");

                            // Do stuff based on choices
                            switch (monChoice)
                            {
                                case 1: x = xDefault;
                                    settMenuChoice = 0;
                                    break;

                                case 2: x = xDefault - 1920;
                                    settMenuChoice = 0;
                                    break;

                                case 3: x = xDefault + 1920;
                                    settMenuChoice = 0;
                                    break;

                                case 5: nextMenu = 0;
                                    settMenuChoice = 0;
                                    break;

                                default:
                                    Console.WriteLine("Invalid Input");
                                    break;
                            }
                            #endregion
                            break;

                        case 2:
                            #region XYCords
                            Console.WriteLine("Enter 1 for manual cord entry, 2 for automatic cord entry");
                            Console.WriteLine("Enter 5 for Settings Menu");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1: Console.WriteLine("Enter X cord, then Y cord");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    y = Convert.ToInt32(Console.ReadLine());
                                    settMenuChoice = 0;
                                    break;

                                case 2: Console.WriteLine("Enter any letter or number after moving cursor to location");
                                    windowsClick.windowsClick.currentMouseLocation(ref x, ref y);
                                    settMenuChoice = 0;
                                    break;
                                case 5:
                                    nextMenu = 0;
                                    settMenuChoice = 0;
                                    break;

                                default:
                                    Console.WriteLine("Invalid Input.");
                                    break;

                            }
                            #endregion
                            break;

                        case 3:
                            #region mouseButton
                            Console.WriteLine("Enter 1 for Left Mouse Button (default), 2 for Right Mouse Button");
                            Console.WriteLine("Enter 5 for Settings Menu");

                            mouse = Convert.ToInt32(Console.ReadLine());

                            switch (mouse)
                            {
                                case 1:
                                    mouse = 0;
                                    settMenuChoice = 0;
                                    break;
                                case 2:
                                    mouse = 1;
                                    settMenuChoice = 0;
                                    break;
                                case 5:
                                    settMenuChoice = 0;
                                    break;
                                default:
                                    Console.WriteLine("Invalid Input.");
                                    break;
                            }
                            break;
                            #endregion
                        case 4:
                            Console.WriteLine("");
                            Console.WriteLine("Enter interval for program to click in minutes");
                            time = Convert.ToDouble(Console.ReadLine());
                            settMenuChoice = 0;
                            break;
                        case 5:
                            break;

                        default:
                            Console.WriteLine("Invalid Choice.");
                            settMenuChoice = 0;
                            break;
                        #endregion
                    }
                    #endregion
                }
            }
            return cont;
        }
        #endregion



        static void textColor(int color)
        {
            if (color == 0)
                Console.ForegroundColor = ConsoleColor.White;
            else if (color == -1)
                Console.ResetColor();
        }
    }
}
