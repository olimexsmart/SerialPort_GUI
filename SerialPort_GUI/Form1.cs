/*
 * This utility is made by a maker for others makers
 */

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

namespace SerialPort_GUI
{
    public partial class MainForm : Form
    {
        bool connected = false;
        SerialPort serialPort;
        StringBuilder sb;
        string data = ""; //main buffer
        ulong byReceived = 0;
        ulong bySent = 0;
       

        public MainForm()
        {
            InitializeComponent();
            sb = new StringBuilder(data);
            //Pre-select the first port
            COMpick.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())        
                COMpick.Items.Add(s);

            try { COMpick.SelectedIndex = 0; }
            catch (ArgumentOutOfRangeException) { }

            //Pre-select 9600, the most used by Arduino
            baudRate.SelectedIndex = 2;

            //Instance the port 
            //serialPort = new SerialPort();
        }

        //Update the list of serialports
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            COMpick.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                COMpick.Items.Add(s);
            }
        }

        //Connect/Disconnect button
        private void ConnectB_Click(object sender, EventArgs e)
        {
            //Get baud from the form
            int baud = 0;
            try
            {
                baud = Convert.ToInt32(baudRate.SelectedItem.ToString());
            }
            catch (NullReferenceException) //the user can wipe away the combox text
            {
                MessageBox.Show("Select a valid baud rate.");
            }

            if (!connected && baud > 0)
            {
                //Instance with all parameters
                serialPort = new SerialPort(COMpick.SelectedItem.ToString(), baud, Parity.None, 8, StopBits.One);
                serialPort.ReceivedBytesThreshold = 100;
                serialPort.DataReceived += SerialPort_DataReceived;
                try
                {
                    serialPort.Open();                    
                    connected = true;
                    outBox.Text = "";
                    data = "";
                    bySentN.Text = formatData(bySent); //update status strip
                    byReceivedN.Text = formatData(byReceived); //update status strip
                    toolStatus.Text = "Connected";
                    ConnectB.Text = "Disconnect";
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Baud rate not valid.");
                    connected = false;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Port name not valid.");
                    connected = false;
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Access denied, try close applications that may be using the port.");
                    connected = false;
                }
            }
            else if(serialPort.IsOpen) //else nothing, if the cable is disconnected when the port is open, the .close() will crash.
            {
                connected = false;                
                serialPort.Close();

                toolStatus.Text = "Disconnected";
                ConnectB.Text = "Connect";
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.BytesToRead > 0)
            {
                string newBytes = ""; //data data in this update, used in autoscroll feature
                newBytes = serialPort.ReadExisting(); //get data

                sb.Append(newBytes);
                byReceived += (ulong)newBytes.Length;
                byReceivedN.Text = formatData(byReceived); //update status strip

                if (autoscrollMenu.Checked)
                {
                    outBox.AppendText(newBytes);                
                }
                else
                {

                }
            }

        }

        //Send string
        private void SendB_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Write(inBox.Text); //send
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Not connected");
            }
            catch(InvalidOperationException)
            {
                MessageBox.Show("Not connected");
            }

            data += "\n" + ">> " + inBox.Text + "\n"; //display 'n' store to keep a conversation

            bySent += (ulong) inBox.TextLength;
            bySentN.Text = formatData(bySent); //update status strip

            inBox.Clear();
        }

        //Send when Enter is pressed
        private void inBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                e.SuppressKeyPress = true;
                SendB_Click(inBox, e);
            }

        }

        //Quit from the menu - a must have
        private void quitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Update the form with new data every 10 millis
        private void timer_Tick(object sender, EventArgs e)
        {
        }

        private void saveFileMenu_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.File.WriteAllText(saveFileDialog.FileName, data);
        }

        private void inputFileMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be done!");
        }

        private void clearAllMenu_Click(object sender, EventArgs e)
        {
            data = "";
            outBox.Text = "";
            byReceived = 0;
            byReceivedN.Text = formatData(byReceived); //update status strip
            bySent = 0;
            bySentN.Text = formatData(bySent); //update status strip

            inBox.Clear();
        }

        private void copyAllMenu_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(data);
        }

        //this fx create a compact rappresentation of data values
        private string formatData(ulong bytes)
        {
            if (bytes < 1024)
                return bytes.ToString() + " B";
            if (bytes < 1048576)
            {
                float byt = bytes / 1024f;
                return byt.ToString("F2") + " KB";
            }
            else
            {
                float byt = bytes / 1048576f;
                return byt.ToString("F2") + " MB";
            }
        }
    }
}
