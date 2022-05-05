using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSerialPort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string LogMessage = "";

        private void btnEnter_Click(object sender, EventArgs e)
        {
           TxtPantalla.Text += InputTxt.Text;
        }

        private void TxtPantalla_TextChanged(object sender, EventArgs e)
        {
            TxtPantalla.Text = LogMessage;
        }

        private void InputTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
