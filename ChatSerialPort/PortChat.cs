using System;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatSerialPort
{
   

    public class PortChat
    {
        
        public static string NamePort = "";
        public static string Config_de_Puerto = "";
        public static string Mensajes_Escritos = "";
        public static string Mensajes_Leidos = "";
        public static string statusPort = "";
        //Variables para la conexion por Socket
        IPHostEntry host;
        IPAddress address;
        public static IPEndPoint endPoint;
        public static Socket s_Client;


        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public PortChat(string IP, int port)
        {
            
            try
            {
                host = Dns.GetHostByName(IP);
                address = host.AddressList[0];
                endPoint = new IPEndPoint(address, port);

                s_Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                Open();

            }
            catch (Exception ex)
            {
                statusPort = ex.Message;
            }           
            
               
        }

        public static void Send(string mensaje)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(mensaje);

            s_Client.Send(buffer);
            Mensajes_Escritos = "Mensaje enviado";
        }

        public static void Read()
        {

            try
            {
                
               


            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TimeoutException ex)
            {
                //Mensajes_Leidos += ex.Message;
                Console.WriteLine("In timeoutException "+ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("in Exception" + ex.Message);
                Mensajes_Leidos += ex.Message;
            }
        }
        

        public static void Open()
        {
            try
            {

                s_Client.Connect(endPoint);
                statusPort = "Cliente conectado";
               
            }
            catch (Exception e)
            {
                statusPort = e.Message; 
            }

            
                       
        }

        #region Codigo comentado

        //Metodo Read
        //byte[] bytes = new byte[64];
        //var longitud = _serialPort.Read(bytes, 0, 64);
        //string respuesta = BitConverter.ToString(bytes, 0 , longitud);
        //respuesta = respuesta.Replace("-", "");
        //Mensajes_Leidos += respuesta;

        //Metodo Open
        //    if (_serialPort != null)
        //    {
        //        if (!_serialPort.IsOpen)
        //        {
        //            _serialPort.Open();
        //            statusPort = "El Puerto fue abierto exitosamente";
        //        }
        //        else
        //        {
        //            statusPort = "El Puerto fue abierto exitosamente";
        //        }
        //    }
        //    else
        //    {
        //        statusPort = "Debe abrir el puerto antes de escribir datos";
        //    }

        #endregion
    }
}
