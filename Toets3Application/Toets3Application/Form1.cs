using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toets3Application
{
    public partial class Form1 : Form
    {
        private SerialMessenger serialMessenger;
        private Timer readMessageTimer;
        private int d;
        private enum Die
        {
            d2 = 0, d3 = 1, d4 = 2, d6 = 3, d8 = 4, d10 = 5, d12 = 6, d20 = 7, d100 = 8
        }
        private enum Mode
        {
            Normal = 0, Disadvantage = 1, Advantage = 2
        }
        List<int> d2 = new List<int>();
        List<int> d3 = new List<int>();
        List<int> d4 = new List<int>();
        List<int> d6 = new List<int>();
        List<int> d8 = new List<int>();
        List<int> d10 = new List<int>();
        List<int> d12 = new List<int>();
        List<int> d20 = new List<int>();
        List<int> d100 = new List<int>();
        public Form1()
        {
            InitializeComponent();
            cbDie.DataSource = Enum.GetNames(typeof(Die));
            cbMode.DataSource = Enum.GetNames(typeof(Mode));
            MessageBuilder messageBuilder = new MessageBuilder('#', '%');
            serialMessenger = new SerialMessenger("COM5", 9600, messageBuilder);

            readMessageTimer = new Timer();
            readMessageTimer.Interval = 10;
            readMessageTimer.Tick += new EventHandler(ReadMessageTimer_Tick);
        }
        private void ReadMessageTimer_Tick(object sender, EventArgs e)
        {
            string[] messages = serialMessenger.ReadMessages();
            if (messages != null)
            {
                foreach (string message in messages)
                {
                    processReceivedMessage(message);
                }
                lbThrows.SelectedIndex = lbThrows.Items.Count - 1;
                lbThrows.SelectedIndex = -1;
            }
        }

        private void processReceivedMessage(string message)
        {
            if (message.StartsWith("adv"))
            {
                label1.Text = message + " Roll";
            }
            else if (message.StartsWith("dis"))
            {
                label1.Text = message + " Roll";
            }
            else if (message.StartsWith("d"))
            {
                d = Convert.ToInt32(message.Remove(0, 1));
                label2.Text = "Die = " + message;
            }
            else if (message.StartsWith("rn"))
            {
                int number = Convert.ToInt32(message.Remove(0, 2));
                switch (d)
                {
                    case 2:
                        d2.Add(number);
                        ListUpdate(d2);
                        break;
                    case 3:
                        d3.Add(number);
                        ListUpdate(d3);
                        break;
                    case 4:
                        d4.Add(number);
                        ListUpdate(d4);
                        break;
                    case 6:
                        d6.Add(number);
                        ListUpdate(d6);
                        break;
                    case 8:
                        d8.Add(number);
                        ListUpdate(d8);
                        break;
                    case 10:
                        d10.Add(number);
                        ListUpdate(d10);
                        break;
                    case 12:
                        d12.Add(number);
                        ListUpdate(d12);
                        break;
                    case 20:
                        d20.Add(number);
                        ListUpdate(d20);
                        break;
                    case 100:
                        d100.Add(number);
                        ListUpdate(d100);
                        break;
                }
            }
            else if (message.StartsWith("total"))
            {
                label1.Text = "Totaal: " + message.Remove(0, 5);
            }
        }

        private void ListUpdate(List<int> x)
        {
            lbThrows.Items.Clear();
            foreach (int i in x)
            {
                lbThrows.Items.Add(i);
            }
        }
        private void Disconnect()
        {
            try
            {
                lblConnection.Text = "Disconnected";
                lblConnection.BackColor = Color.Red;
                readMessageTimer.Enabled = false;
                serialMessenger.Disconnect();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialMessenger.Connect();
                lblConnection.Text = "Connected with Arduino";
                lblConnection.BackColor = Color.Lime;
                readMessageTimer.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();
        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            if (cbMode.Text == "Normal")
            {
                serialMessenger.SendMessage(cbDie.Text + ":" + nudAm.Value.ToString());
            }            
            else if (cbMode.Text == "Advantage")
            {
                serialMessenger.SendMessage(cbDie.Text + "adv");
            }
            else if(cbMode.Text == "Disadvantage")
            {
                serialMessenger.SendMessage(cbDie.Text + "dis");
            }
        }
    }
}
