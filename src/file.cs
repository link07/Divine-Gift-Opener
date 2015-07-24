/*---------------------------------------------------------------------------------------------------------------------------------------
 * Name:          XML File Read / Write 
 * Author:        Tyler aka Link aka Zafar
 *
 * Description:
 * Read and Write XML Files to save settings for Interval Click
 * 
 * 
 * Version History:
 * v0.0.1 on 7/23/2015 : Start work on file usage
 * --------------------------------------------------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace intervalClickGraphic
{
    public class file
    {
        public void readFile ()
        {
            ArrayList arrText = new ArrayList();
            StreamReader stream = new StreamReader("%appdata%\\Zafar\\Interval Click\\Settings.xml");

            XmlTextReader reader = new XmlTextReader(stream);


        }

    }
}
