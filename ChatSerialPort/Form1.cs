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
            //LogMessage = PortChat.Config_de_Puerto;
            //TxtPantalla.Text = LogMessage;
        }
               

        private void btnEnter_Click(object sender, EventArgs e)
        {
            PortChat.Open();
            PortChat._serialPort.WriteLine(InputTxt.Text);
            LogMessage += "\n\r" + InputTxt.Text;
            TxtPantallaOutput.Text = LogMessage;
            InputTxt.Text = "";
        }
       
        private void BtnRead_Click(object sender, EventArgs e)
        {

            PortChat.Read();
            StringBuilder sb = new StringBuilder();
            sb.Append("\n\r" + PortChat.Mensajes_Leidos);
            TxtPantalla.Text += sb;
            sb = null;
        }
    }
}
