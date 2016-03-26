using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using TwitchChatSharp;

namespace Clapperboard
{
    public partial class Clapperboard : Form
    {
        public TwitchConnection client;
        public string uname;
        public DateTime last_switch;

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public const int KEYEVENTF_KEYDOWN = 0x0000; //Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
        public const int VK_LCONTROL = 0xA2; //Left Control key code
        public const int A_KEY = 0x41; //A key code
        public const int C_KEY = 0x43; //C key code
        public const int VK_LMENU = 0xA4; //LALT key code
        public const int NUM7_KEY = 0x67; //LALT key code

        public Clapperboard()
        {
            last_switch = new DateTime(1970, 1, 1);
            uname = "justinfan" + (new Random()).Next(100000, 1000000).ToString();
            client = new TwitchConnection(
                cluster: ChatEdgeCluster.Aws,
                nick: uname,
                capRequests: new string[] { "twitch.tv/tags" },
                ratelimit: 1500,
                secure: true
                );

            InitializeComponent();

            client.Connected += (object sender, IrcConnectedEventArgs e) =>
            {
                AppendDebugText("Connected");
                AppendDebugText("----------------------------------------");
            };
            client.Reconnected += (object sender, EventArgs e) =>
            {
                AppendDebugText("Reconnected");
                AppendDebugText("----------------------------------------");
            };
            client.MessageReceived += (object sender, IrcMessageEventArgs e) =>
            {
                if (e.Message.Command == TwitchChatSharp.IrcCommand.Ping)
                {
                    client.SendRaw("PONG\n");
                }
                else
                {
                    HandleMessage(e.Message);
                }
            };

        }

        delegate void HandleMessageCB(IrcMessage message);
        private void HandleMessage(IrcMessage message)
        {
            if (SwitchTimeout.InvokeRequired)
            {
                HandleMessageCB d = new HandleMessageCB(HandleMessage);
                this.Invoke(d, new object[] { message });
            }
            else
            {
                if (message.User == uname || message.User == "tmi.twitch.tv" || message.User == uname + ".tmi.twitch.tv")
                {
                    return;
                }
                if (!CheckUser(message))
                {
                    return;
                }
                try
                {
                    if ((DateTime.Now - last_switch).TotalSeconds < Int32.Parse(SwitchTimeout.Text))
                    {
                        return;
                    }
                }
                catch (System.FormatException)
                {
                    return;
                }
                AppendDebugText(message.User);
                AppendDebugText(message.Message);
                AppendDebugText(last_switch.ToString());
                AppendDebugText("----------------------------------------");
                if (Cmd1Enable.Checked && Cmd1Text.Text == message.Message)
                {
                    //ActivateApp("obs");
                    /*keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
                    keybd_event(VK_LMENU, 0, KEYEVENTF_KEYDOWN, 0);
                    keybd_event(NUM7_KEY, 0, KEYEVENTF_KEYDOWN, 0);
                    
                    keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(VK_LMENU, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(NUM7_KEY, 0, KEYEVENTF_KEYUP, 0);*/
                    keybd_event(A_KEY, 0, KEYEVENTF_KEYDOWN, 0);
                    keybd_event(C_KEY, 0, KEYEVENTF_KEYDOWN, 0);
                    keybd_event(A_KEY, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(C_KEY, 0, KEYEVENTF_KEYUP, 0);
                    /*try
                    {
                        SendKeys.SendWait(Cmd1Command.Text);
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show(Cmd1Command.Text + " Invalid");
                    }*/
                    last_switch = DateTime.Now;
                }
            }
        }

        private bool CheckUser(IrcMessage message)
        {
            if (message.User == ChannelNameBox.Text.ToLower())
            {
                return true;
            }
            else if (message.Tags["mod"] == "1" && YesMods.Checked)
            {
                return true;
            }
            else if (message.Tags["subscriber"] == "1" && YesSubs.Checked)
            {
                return true;
            }
            else if (YesAll.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        delegate void AppendDebugTextCB(string text);
        private void AppendDebugText(string text)
        {
            if (DebugBox.InvokeRequired)
            {
                AppendDebugTextCB d = new AppendDebugTextCB(AppendDebugText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                DebugBox.AppendText(text);
                DebugBox.AppendText(Environment.NewLine);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void JoinButton_Click(object sender, EventArgs e)
        {
            AppendDebugText("Connecting");
            await client.ConnectAsync();
            client.JoinChannel("#" + ChannelNameBox.Text.ToLower());
            ChannelNameBox.Enabled = false;
            JoinButton.Enabled = false;
            LeaveButton.Enabled = true;
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            client.PartChannel("#" + ChannelNameBox.Text.ToLower());
            ChannelNameBox.Enabled = true;
            JoinButton.Enabled = true;
            LeaveButton.Enabled = false;
        }

        private void Cmd1Enable_CheckedChanged(object sender, EventArgs e)
        {
            Cmd1Command.Enabled = !Cmd1Enable.Checked;
            Cmd1Text.Enabled = !Cmd1Enable.Checked;
        }

        void ActivateApp(string processName)
        {
            Process[] p = Process.GetProcessesByName(processName);

            // Activate the first application we find with this name
            if (p.Count() > 0)
                SetForegroundWindow(p[0].MainWindowHandle);
        }
    }
}
