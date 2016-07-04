using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Diagnostics;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        TcpClient client;
        Stream s;
        public Form1()
        {
            InitializeComponent();
        }

        private void sendmsgbtn_Click(object sender, EventArgs e)
        {
            client = new TcpClient("192.168.1.2", 8181);
            try
            {
                s = client.GetStream();
                StreamReader sr = new StreamReader(s);
                StreamWriter sw = new StreamWriter(s);
                statuslbl.Text = sr.ReadLine();
                sw.WriteLine("Client connected");
                sw.Close();
                sr.Close();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                s.Close();
                client.Close();
            }
        }
    }
}
