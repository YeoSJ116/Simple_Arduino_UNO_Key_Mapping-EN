using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using System.IO.Ports;//For Arduino Serial communication


/// SPARROW 1.0.1 Release Version - EN
/// <summary>
/// Release note
/// Created by 여 상준(Sang-Jun Yeo)
/// Country: 대한민국(Republic of Korea)
/// 
/// 2018_02_27
/// :: SPARROW 1.0.0r - EN
/// Fix minor bugs
/// Not running in startup / Fixform etc...
/// 
/// 2017_11_18
/// :: SPARROW 1.0.0r - EN
/// This version is simple launching
/// Support English version
/// </summary>

namespace Arduino_UNO_Key_Mapping_Host_Software
{
    public partial class Form1 : Form
    {
        //Arduino Serial port speed setting (Hard coding)
        int SerialSpeed = 9600;

        //This is for Cross Thread invoke
        private delegate void TextData(string sData);
        private void RXvalue(string sData) {RXmsg.Text = sData;}

        //Arduino socket create
        private SerialPort ArduinoSP;
        void Socket_Setup()
        {
            try
            {
                SerialPort ArduinoSP = new SerialPort();
            }
            catch
            {
                MessageBox.Show("Please check Arduino state and run this program after connection.", "Arduino socket setup error");
            }
        }

        //This is for Virtual Key press/up method
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, ref int dwExtralnfo);
        private int Info=0;

        //This is for Virtual key code (ASCII)
        private const int KEYDOWN = 0x100;
        private const int KEYUP = 0x101;
        private const int Enter_key = 0x0D;
        //--For key down------------//
        private const int A_key = 0x41;
        private const int B_key = 0x42;
        private const int C_key = 0x43;
        private const int D_key = 0x44;
        private const int E_key = 0x45;
        //--For key up--------------//
        private const int a_key = 0x61;
        private const int b_key = 0x62;
        private const int c_key = 0x63;
        private const int d_key = 0x64;
        private const int e_key = 0x65;

        public Form1()
        {
            InitializeComponent();
            //This code jst update Port list
            portlist.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            portlist.Items.AddRange(ports);
            portlist.SelectedIndex = 0;
        }
        //Update Port list
        private void refresh_Click(object sender, EventArgs e)
        {
            portlist.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            portlist.Items.AddRange(ports);
        }
        //Try connect port
        //If this program isn't work please check the Arduino port number
        private void connectArdoino_Click(object sender, EventArgs e)
        {
            if(ArduinoSP.IsOpen == false)
            {
                try
                {
                    ArduinoSP.PortName = portlist.Text;
                    ArduinoSP.BaudRate = SerialSpeed;
                    ArduinoSP.Open();
                    connectArdoino.Text = "Connected";
                }
                catch
                {
                    MessageBox.Show("Please check the Arduino port Number", "Connect error!");
                }
            }else
            {
                ArduinoSP.Close();
                connectArdoino.Text = "Connect";
            }


        }

        //Automatically disconnect when program close
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ArduinoSP.IsOpen == true) ArduinoSP.Close();
        }

        //Listening for Arduino serial port message.
        //DataReceive >>>stirng>>> Append
        void ArduinoSP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Append(ArduinoSP.ReadExisting());
        }
        //DataReceive >>>stirng>>> Append
        void Append(String Read)
        {
            //If you want more faster, You can delete this Invoke method
            Invoke(new TextData(RXvalue), Read); //Winform "RX:" Message return (Invoke)

            //Keys down:: Keys press
            if (Read.Contains("A"))
            {
                keybd_event(A_key, 0, KEYDOWN, ref Info);
            }
            if (Read.Contains("B"))
            {
                keybd_event(B_key, 0, KEYDOWN, ref Info);
            }
            if (Read.Contains("C"))
            {
                keybd_event(C_key, 0, KEYDOWN, ref Info);
            }
            if (Read.Contains("D"))
            {
                keybd_event(D_key, 0, KEYDOWN, ref Info);
            }
            if (Read.Contains("E"))
            {
                keybd_event(E_key, 0, KEYDOWN, ref Info);
            }

            //Keys up
            if (Read.Contains("1"))
            {
                keybd_event(a_key, 0, KEYUP, ref Info);
            }
            if (Read.Contains("2"))
            {
                keybd_event(b_key, 0, KEYUP, ref Info);
            }
            if (Read.Contains("3"))
            {
                keybd_event(c_key, 0, KEYUP, ref Info);
            }
            if (Read.Contains("4"))
            {
                keybd_event(d_key, 0, KEYUP, ref Info);
            }
            if (Read.Contains("5"))
            {
                keybd_event(e_key, 0, KEYUP, ref Info);
            }
        }

        //Hide (true)
        private void hideForm_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            this.Hide();
            notifyIcon1.ShowBalloonTip(10);
        }
        //Hide (false)
        private void notifyIcon1_MouseClick(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }
        //Hide (false)
        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }

        //This code just show the "Program Information"
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Programe_Info InfoForm = new Programe_Info();
            InfoForm.Show();
        }
    }
}
