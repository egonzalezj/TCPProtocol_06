/* File name: program.cs
 * Description:
 * TCP Server.
 * Receive data from clients.
 * Date: May 12th, 2016.
 * Version: 1.0.
 * 
 * History:
 * v1.0     12/05/2016  Sockets connection.
 */

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCP_Server
{
    class Program
    {
        static void Main()
        {
            TcpListener server = null;
            NetworkStream stream;
            try
            {
                //Set the TCPListener on port 4444
                const int port = 4444;
                IPAddress ip = new IPAddress(new byte[] { 10, 6, 2, 7 });
                server = new TcpListener(ip, port);
                //Start listening for client requests
                server.Start();
                Console.WriteLine("Esperando conexión...");
                //Listening loop
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    IPAddress clientIP = IPAddress.Parse(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString());
                    string clientPort = ((IPEndPoint)client.Client.RemoteEndPoint).Port.ToString();
                    Console.WriteLine(clientIP + ":" + clientPort + " conectado!");
                    stream = client.GetStream();
                    byte[] data = new byte[140];
                    stream.Read(data, 0, data.Length);
                    Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));
                    client.Close();
                }
            }

            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            finally
            {
                //Stop listening for new clients
                server.Stop();
            }

            Console.ReadKey();
        }
    }
}