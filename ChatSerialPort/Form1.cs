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
        public string LogMessage = "";
        public Form1()
        {
            InitializeComponent();
            LogMessage = PortChat.Config_de_Puerto;
            TxtPantalla.Text = LogMessage;
        }

        

        private void btnEnter_Click(object sender, EventArgs e)
        {
            LogMessage += InputTxt.Text;
            LogMessage += "\n\r";
            TxtPantalla.Text = LogMessage;
            InputTxt.Text = "";
        }

        private void TxtPantalla_TextChanged(object sender, EventArgs e)
        {
            //TxtPantalla.Text = LogMessage;
            //LogMessage += "\n\r";
        }

        private void InputTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
