/*---------------------------------------------------------------------------------------------------------------------------------------
 * Name:          About Interval Click
 * Author:        Tyler aka Link aka Zafar
 *
 * Description:
 * Show an about of Interval Click
 * 
 * 
 * Version History:
 * v1.0 on 7/23/2015 : Create about form
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

namespace aboutForm
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            rtbAbout.Text = "Interval Click was created by Tyler / Zafar\r\n\r\nIt started out as a way to click something called Divine Gifts in an MMO called Archeage, it has since advanced to what it is today. \r\n\r\n\r\nVisit https://github.com/link07/Interval-Click-Graphic for updates";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbAbout_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", e.LinkText);
        }
    }
}
