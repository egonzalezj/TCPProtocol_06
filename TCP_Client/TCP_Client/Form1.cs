/* File name: program.cs
 * Description:
 * TCP Server.
 * Send text data to server.
 * Date: May 12th, 2016.
 * Version: 1.0.
 * 
 * History:
 * v1.0     12/05/2016  Sockets connection.
 * v1.1     12/05/2016  TcpClient object istead of Socket object.
 */

using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.Text;

namespace TCP_Client
{
    public partial class frmTCP_Client : Form
    {
        TcpClient client;
        NetworkStream stream;

        public frmTCP_Client()
        {
            InitializeComponent();
        }

        private void frmTCP_Client_Load(object sender, EventArgs e)
        {
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            //Socket server port
            int port = int.Parse(txt_serverPort.Text);
            //Server IP address
            IPAddress ip = new IPAddress(new byte[] {byte.Parse(txt_serverIP_1.Text), byte.Parse(txt_serverIP_2.Text), byte.Parse(txt_serverIP_3.Text), byte.Parse(txt_serverIP_4.Text)});
            //Init a new instance for IPEndPoint class
            IPEndPoint ep = new IPEndPoint(ip, port);

            try
            {
                client = new TcpClient();
                //Make TcpClient connection
                client.Connect(ep);
                //Updates status textBox
                txt_connectionStatus.Text = "Connected!";
                txt_connectionStatus.BackColor = Color.Green;
                //Get local IP address
                IPAddress clientIP = IPAddress.Parse(((IPEndPoint)client.Client.LocalEndPoint).Address.ToString());
                //Get local Port
                string clientPort = ((IPEndPoint)client.Client.LocalEndPoint).Port.ToString();
                //Display local IP address and port
                txt_localIP.Text = clientIP.ToString();
                txt_localPort.Text = clientPort;
                //Enables message textBox
                txt_message.Enabled = true;
            }
            catch
            {
                txt_data.Text = "Error de conexión";
            }
        }

        private void txt_message_TextChanged(object sender, EventArgs e)
        {
            btn_send.Enabled = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //Closes the connection
            client.Close();
            Close();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //
            stream = client.GetStream();
            byte[] data = Encoding.ASCII.GetBytes(txt_message.Text);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
    }
}
