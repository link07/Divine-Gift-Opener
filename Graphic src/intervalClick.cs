/*---------------------------------------------------------------------------------------------------------------------------------------
 * Name:          Interval Click Graphic
 * Author:        Tyler aka Link aka Zafar
 *
 * Description:
 * A graphic version of Interval Click, to make navigating the menu easier
 * 
 * 
 * Version History:
 * v0.9 on 5/19/2015 : A lesser version of the console program (notably missing the auto find points function), but it works
 * v0.9.1 on 6/8/2015 : Update TabIndexs, make the time NUD allow decimal places
 * Split from Console version 2.1
 * --------------------------------------------------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Interval_Click_Graphic;

namespace Interval_Click_Graphic
{

    public partial class intervalClick : Form
    {
        public threadHandler thread = new threadHandler();


        public intervalClick()
        {
            InitializeComponent();
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            int button = 0;
            if (btnOnOff.Text == "Start")
            {
                if (cbLeft.Checked == true && cbRight.Checked == true)
                    button = 2;
                else if (cbRight.Checked == true)
                    button = 1;
                else
                    button = 0;

                // Do the thing
                thread.startThread(Convert.ToInt32(nudX.Value), Convert.ToInt32(nudY.Value), button, Convert.ToDouble(nudTime.Value));

                btnOnOff.Text = "Stop";
            }
            else
            {
                // stop the thing
                thread.exitThread();

                btnOnOff.Text = "Start";
            }
        }

        private void intervalClick_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close incase "stop" wasn't pressed before closing
            thread.exitThread();
        }
    }
}