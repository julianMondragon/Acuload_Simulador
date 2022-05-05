using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSerialPort
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread ConfigPort = new Thread(RunConfig);
            ConfigPort.Start();
            Application.Run(new Form1());
        }

        public static void RunConfig()
        {
            PortChat Configport = new PortChat();
        }
    }
}


