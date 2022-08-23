using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ChatSerialPort
{
    public partial class Form1 : Form
    {
        public string LogMessage = "";
        public static string Adress = "";
        static bool _continue;

        public Form1()
        {
            _continue = true;
            InitializeComponent();
        //    Thread readThread = new Thread(delegate ()
        //    {
        //        Tread();
        //    });
        //    readThread.Start();
        }
               

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                PortChat.Send(InputTxt.Text);
                //0141022190B4
                //PortChat.Open();
                //txtStatusPort.Text = PortChat.statusPort;
                //if (PortChat._serialPort != null)
                //{
                //    byte[] Bytes = FromHexStringToArrBytes(InputTxt.Text);                  
                //    PortChat._serialPort.Write( Bytes, 0, Bytes.Length);
                //    LogMessage += "\n\r" + InputTxt.Text;
                //    Output.Text = LogMessage;
                //    InputTxt.Text = "";
                //}
            }
            catch (Exception ex)
            {
                txtStatusPort.Text = ex.Message;
            }
            
        }
       
        private void BtnRead_Click(object sender, EventArgs e)
        {
            try
            {
                PortChat.Read();
                StringBuilder sb = new StringBuilder();
                sb.Append("\n\r" + PortChat.Mensajes_Leidos);
                TxtPantalla.Text = sb.ToString();
                sb = null;
            }
            catch (Exception ex)
            {
                txtStatusPort.Text = ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames();
            comboBoxCOMs.Items.AddRange(puertos);
        }

        /// <summary>
        /// Boton Open 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private  void button1_Click(object sender, EventArgs e)
        {
            Adress = comboBoxCOMs.Text;
            PortChat socket = new PortChat(Adress, 11000);
            //Thread ConfigPort =new Thread(RunConfig);
            //ConfigPort.Start();
            txtStatusPort.Text = PortChat.statusPort;

        }
        public static void RunConfig()
        {
            //PortChat.NamePort = PortName;
           // PortChat Configport = new PortChat();
        }

        private void txtStatusPort_TextChanged(object sender, EventArgs e)
        {
            if(txtStatusPort.Text == "")
            {
                txtStatusPort.Text = "Puerto Abierto";
                button1.Enabled = false;
            }
            else if( txtStatusPort.Text == "Puerto Abierto") 
            {
                button1.Enabled = false;
            }
            else if (txtStatusPort.Text == "El Puerto fue abierto exitosamente")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled=true;
            }
            
        }

        public void Tread()
        {

            while (_continue)
            {
                Task.Delay(1000).Wait();
                try
                {
                    //if(PortChat._serialPort != null)
                    //    PortChat.Read();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("\n\r" + PortChat.Mensajes_Leidos);
                    if (TxtPantalla.InvokeRequired)
                    {
                        TxtPantalla.Invoke(new MethodInvoker(delegate
                        {
                            TxtPantalla.Text = sb.ToString();
                        }));
                    }
                    
                    sb = null;
                }
                catch (Exception ex)
                {
                    //txtStatusPort.Text = ex.Message;
                    if (txtStatusPort.InvokeRequired)
                    {
                        txtStatusPort.Invoke(new MethodInvoker(delegate
                        {
                            txtStatusPort.Text = ex.Message;
                        }));
                    }
                }
            }
        }
        public static byte[] FromHexStringToArrBytes(string hexString)
        {
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return bytes; 
        }

    }
}
