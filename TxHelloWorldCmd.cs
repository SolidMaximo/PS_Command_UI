using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecnomatix.Engineering;

namespace TrainingCommands
{
    public class TxHelloWorldCmd : TxButtonCommand
    {
        public override string Category
        {
            get
            {
                return StringTable.CATEGORY;
            }
        }

        public override string Name
        {
            get
            {
                return StringTable.NAME;
            }
        }

        public override void Execute(object cmdParams) //defines actual work done inside Process Simulate
        {
            //add message box-- need to reference windows.forms library 
            MessageBox.Show("Hello World!", Name, MessageBoxButtons.OK, MessageBoxIcon.Information); 

        }

        public override string Bitmap
        {
            get
            {
                return "HelloWorld.bmp";
            }
        }
        public override string LargeBitmap
        {
            get
            {
                return "HelloWorld.png";
            }
        }
    }
}

