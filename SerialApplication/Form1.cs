using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.IO.Ports;

namespace SerialApplication
{
    public delegate void textAppendD(string message);

    public partial class Form1 : Form
    {
        textAppendD textAppend;
        public SerialPort _serialPort;
        public bool stop;
        private Task t;

        public void textAppendMethod(string text)
        {
            if (this.infoTextBox.InvokeRequired)
            {
                this.infoTextBox.Invoke(new textAppendD(textAppendMethod), text);
            }
            else
            {
                this.infoTextBox.AppendText(text);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            stop = false;
            textAppend = new textAppendD(textAppendMethod);
            string[] portList = SerialPort.GetPortNames();
            portComboBox.DataSource = portList;
            portComboBox.SelectedIndex = 0;

            Int32[] baudRate = {4800,9600,19200,38400,57600,115200};
            baudComboBox.Items.Clear();
            //baudComboBox.Items.AddRange(baudRate);
            foreach(Int32 i in baudRate){
                baudComboBox.Items.Add(i.ToString());
            }
            baudComboBox.SelectedIndex = 1;

            this.writeButton.Enabled = false;
            this.stopListening_Btn.Enabled = false;
            this.checkBoxXonXoff.Enabled = true;
            this.checkBoxHardwareHandshaking.Enabled = true;
            this.startListening_Btn.Enabled = true;
            stopLoop_Btn.Enabled = false;

        }

        //private void updateBaudRateCollection()
        //{
        //    SerialPort port = new SerialPort(this.portComboBox.SelectedValue.ToString());
        //    port.Open();
        //    object p = port.BaseStream.GetType().GetField("commProp", 
        //        System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(port.BaseStream);
        //    Int32 settableBaud = (Int32)p.GetType().GetField("dwSettableBaud",
        //        System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public).GetValue(p);
        //    port.Close();
        //}

        private void portComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //updateBaudRateCollection();
        }

        private void startListening_Btn_Click(object sender, EventArgs e)
        {
            this.baudComboBox.Enabled = false;
            this.portComboBox.Enabled = false;
            this.startListening_Btn.Enabled = false;
            this.stopListening_Btn.Enabled = true;
            this.checkBoxHardwareHandshaking.Enabled = false;
            this.checkBoxXonXoff.Enabled = false;
            this.writeButton.Enabled = true;

            // Make sure the port is closed before trying to open
            if (_serialPort != null && _serialPort.IsOpen) _serialPort.Close();
            _serialPort = new SerialPort(this.portComboBox.SelectedValue.ToString(), Convert.ToInt32(this.baudComboBox.Text), Parity.None, 8, StopBits.One);
            if (checkBoxXonXoff.Checked)
            {
                _serialPort.Handshake = Handshake.XOnXOff;
            }
            else
            {
                _serialPort.Handshake = Handshake.None;
            }
            if (this.checkBoxHardwareHandshaking.Checked)
            {
                _serialPort.DtrEnable = true; // 
                _serialPort.RtsEnable = true; //
            }
            else
            {
                _serialPort.DtrEnable = false; // 
                _serialPort.RtsEnable = false; //
            }
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived);
            _serialPort.Open();
        }

        void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            textAppend("Entered DataReceived Event!" + Environment.NewLine);
            string text = string.Empty;
            while (_serialPort.BytesToRead != 0)
            {
                int datalength = _serialPort.BytesToRead;
                byte[] data = new byte[datalength];
                int nbrDataRead = _serialPort.Read(data, 0, datalength);
                if (nbrDataRead == 0) return;
                foreach (byte b in data)
                {
                    text += Convert.ToChar(b);
                }
            }
            textAppend("Data: " + text + Environment.NewLine);
            
            if (this.sendReplyCheckBox.Checked == true)
            {
                ReplyData(this.writeText.Text);
            }
        }
        public void ReplyData(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                textAppend("Reply String is Blank, Enter a string, \"NULL\" will be sent.");
                message = "NULL";
            }
            if ((_serialPort != null) && (_serialPort.IsOpen))
            {
                _serialPort.WriteLine(message+Environment.NewLine);
            }
            else
            {
                textAppend("Could not send data, Serial Port not open.");
            }
        }

        private void stopListening_Btn_Click(object sender, EventArgs e)
        {
            stop = true;
            this.baudComboBox.Enabled = true;
            this.portComboBox.Enabled = true;
            this.startListening_Btn.Enabled = true;
            this.stopListening_Btn.Enabled = false;
            this.checkBoxHardwareHandshaking.Enabled = true;
            this.checkBoxXonXoff.Enabled = true;
            this.writeButton.Enabled = false;
            _serialPort.Close();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            //// Make sure the port is closed before trying to open
            //if (_serialPort != null && _serialPort.IsOpen) _serialPort.Close();
            //_serialPort = new SerialPort(this.portComboBox.SelectedValue.ToString(), Convert.ToInt32(this.baudComboBox.Text), Parity.None, 8, StopBits.One);
            _serialPort.NewLine = "\r"; // Following three lines configure for use with Galil Main Serial Port1
            // handshaking options started with start listening button 
            //if (this.checkBoxHardwareHandshaking.Checked)
            //{
            //    _serialPort.DtrEnable = true; // 
            //    _serialPort.RtsEnable = true; //
            //}
            //else
            //{
            //    _serialPort.DtrEnable = false; // 
            //    _serialPort.RtsEnable = false; //
            //}
            //_serialPort.Open();
            if ((_serialPort != null) && (_serialPort.IsOpen))
            {
                _serialPort.WriteLine(this.writeText.Text + Environment.NewLine);
            }
            else
            {
                textAppend(Environment.NewLine + "Could not send data, Serial Port not open." + Environment.NewLine);
            }
            
            //Thread.Sleep(100);
            //_serialPort.Close();
        }

        private void clearTextBtn_Click(object sender, EventArgs e)
        {
            this.infoTextBox.Clear();
        }

        private void loopWrite_btn_Click(object sender, EventArgs e)
        {
            loopWrite_btn.Enabled = false;
            stopLoop_Btn.Enabled = true;
            if (_serialPort != null && _serialPort.IsOpen) _serialPort.Close();
            _serialPort = new SerialPort(this.portComboBox.SelectedValue.ToString(), Convert.ToInt32(this.baudComboBox.Text), Parity.None, 8, StopBits.One);
            if (checkBoxXonXoff.Checked)
            {
                _serialPort.Handshake = Handshake.XOnXOff;
            }
            else
            {
                _serialPort.Handshake = Handshake.None;
            }
            if (this.checkBoxHardwareHandshaking.Checked)
            {
                _serialPort.DtrEnable = true; // 
                _serialPort.RtsEnable = true; //
            }
            else
            {
                _serialPort.DtrEnable = false; // 
                _serialPort.RtsEnable = false; //
            }
            
            _serialPort.Open();

            _serialPort.NewLine = "\r"; // Following three lines configure for use with Galil Main Serial Port1
            t = new Task(spamWrite);
            t.Start();

        }
        private void spamWrite()
        {
            string str;
            while (!stop)
            {
                if ((_serialPort != null) && (_serialPort.IsOpen))
                {
                    str = writeText.Text;
                    _serialPort.WriteLine(str);
                }

                Thread.Sleep(100);
            }
            stop = false;
        }

        private void infoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (infoTextBox.TextLength > 3000) infoTextBox.Text = "";
        }

        private void stopLoop_Btn_Click(object sender, EventArgs e)
        {
            stop = true;
            while (!t.IsCompleted) ;
            _serialPort.Close();
            loopWrite_btn.Enabled = true;
            stopLoop_Btn.Enabled = false;
        }

    }
}
