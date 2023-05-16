using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extensionMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string myName = "Kulpot Sunny Z Wahu";//3 spaces
            this.Text = myName.GetSpaceCount().ToString();
        }
    }
}
