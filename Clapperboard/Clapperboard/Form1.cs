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
        public const int VK_LSHIFT = 0xA0; //Left Shift key code
        public const int VK_LCONTROL = 0xA2; //Left Control key code
        public const int VK_LMENU = 0xA4; //LALT key code
        public const int NUM1_KEY = 0x61;
        public const int NUM2_KEY = 0x62;
        public const int NUM3_KEY = 0x63;
        public const int NUM4_KEY = 0x64;
        public const int NUM5_KEY = 0x65;
        public const int NUM6_KEY = 0x66;
        public const int NUM7_KEY = 0x67;
        public const int NUM8_KEY = 0x68;
        public const int NUM9_KEY = 0x69;

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
                if (ActiveCommands().Contains(message.Message))
                {
                    last_switch = DateTime.Now;
                    AppendDebugText(message.User);
                    AppendDebugText(message.Message);
                    AppendDebugText(last_switch.ToString());
                    AppendDebugText("----------------------------------------");
                    /*keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
                    keybd_event(VK_LMENU, 0, KEYEVENTF_KEYDOWN, 0);
                    keybd_event(NUM7_KEY, 0, KEYEVENTF_KEYDOWN, 0);

                    keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(VK_LMENU, 0, KEYEVENTF_KEYUP, 0);
                    keybd_event(NUM7_KEY, 0, KEYEVENTF_KEYUP, 0);*/
                    PressModifiers(KEYEVENTF_KEYDOWN);
                    if (Num1Text.Text == message.Message)
                    {
                        keybd_event(NUM1_KEY, 0, KEYEVENTF_KEYDOWN, 0);
                        keybd_event(NUM1_KEY, 0, KEYEVENTF_KEYUP, 0);
                    }
                    else if (Num2Text.Text == message.Message)
                    {
                        keybd_event(NUM2_KEY, 0, KEYEVENTF_KEYDOWN, 0);
                        keybd_event(NUM2_KEY, 0, KEYEVENTF_KEYUP, 0);
                    }
                    else if (Num3Text.Text == message.Message)
                    {
                        keybd_event(NUM3_KEY, 0, KEYEVENTF_KEYDOWN, 0);
                        keybd_event(NUM3_KEY, 0, KEYEVENTF_KEYUP, 0);
                    }
                    else if (Num4Text.Text == message.Message)
                    {
                        keybd_event(NUM4_KEY, 0, KEYEVENTF_KEYDOWN, 0);
                        keybd_event(NUM4_KEY, 0, KEYEVENTF_KEYUP, 0);
                    }
                    else if (Num5Text.Text == message.Message)
                    {
                        keybd_event(NUM5_KEY, 0, KEYEVENTF_KEYDOWN, 0);
                        keybd_event(NUM5_KEY, 0, KEYEVENTF_KEYUP, 0);
                    }
                    else if (Num6Text.Text == message.Message)
                    {
                        keybd_event(NUM6_KEY, 0, KEYEVENTF_KEYDOWN, 0);
                        keybd_event(NUM6_KEY, 0, KEYEVENTF_KEYUP, 0);
                    }
                    else if (Num7Text.Text == message.Message)
                    {
                        keybd_event(NUM7_KEY, 0, KEYEVENTF_KEYDOWN, 0);
                        keybd_event(NUM7_KEY, 0, KEYEVENTF_KEYUP, 0);
                    }
                    else if (Num8Text.Text == message.Message)
                    {
                        keybd_event(NUM8_KEY, 0, KEYEVENTF_KEYDOWN, 0);
                        keybd_event(NUM8_KEY, 0, KEYEVENTF_KEYUP, 0);
                    }
                    else if (Num9Text.Text == message.Message)
                    {
                        keybd_event(NUM9_KEY, 0, KEYEVENTF_KEYDOWN, 0);
                        keybd_event(NUM9_KEY, 0, KEYEVENTF_KEYUP, 0);
                    }
                    PressModifiers(KEYEVENTF_KEYUP);
                }
            }
        }

        private void PressModifiers(int dwFlags)
        {
            if (LCtrl.Checked) { keybd_event(VK_LCONTROL, 0, dwFlags, 0); }
            if (LAlt.Checked) { keybd_event(VK_LMENU, 0, dwFlags, 0); }
            if (LShift.Checked) { keybd_event(VK_LSHIFT, 0, dwFlags, 0); }
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

        private List<string> ActiveCommands()
        {
            List<string> ret = new List<string>();
            if (Num1Enable.Checked) { ret.Add(Num1Text.Text); }
            if (Num2Enable.Checked) { ret.Add(Num2Text.Text); }
            if (Num3Enable.Checked) { ret.Add(Num3Text.Text); }
            if (Num4Enable.Checked) { ret.Add(Num4Text.Text); }
            if (Num5Enable.Checked) { ret.Add(Num5Text.Text); }
            if (Num6Enable.Checked) { ret.Add(Num6Text.Text); }
            if (Num7Enable.Checked) { ret.Add(Num7Text.Text); }
            if (Num8Enable.Checked) { ret.Add(Num8Text.Text); }
            if (Num9Enable.Checked) { ret.Add(Num9Text.Text); }
            return ret;
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

        private void Num1Enable_CheckedChanged(object sender, EventArgs e)
        {
            if (Num1Text.Text.Length == 0)
            {
                Num1Enable.Checked = false;
            }
            Num1Text.Enabled = !Num1Enable.Checked;

        }

        private void Num2Enable_CheckedChanged(object sender, EventArgs e)
        {
            if (Num2Text.Text.Length == 0)
            {
                Num2Enable.Checked = false;
            }
            Num2Text.Enabled = !Num2Enable.Checked;

        }

        private void Num3Enable_CheckedChanged(object sender, EventArgs e)
        {
            if (Num3Text.Text.Length == 0)
            {
                Num3Enable.Checked = false;
            }
            Num3Text.Enabled = !Num3Enable.Checked;

        }

        private void Num4Enable_CheckedChanged(object sender, EventArgs e)
        {
            if (Num4Text.Text.Length == 0)
            {
                Num4Enable.Checked = false;
            }
            Num4Text.Enabled = !Num4Enable.Checked;

        }

        private void Num5Enable_CheckedChanged(object sender, EventArgs e)
        {
            if (Num5Text.Text.Length == 0)
            {
                Num5Enable.Checked = false;
            }
            Num5Text.Enabled = !Num5Enable.Checked;

        }

        private void Num6Enable_CheckedChanged(object sender, EventArgs e)
        {
            if (Num6Text.Text.Length == 0)
            {
                Num6Enable.Checked = false;
            }
            Num6Text.Enabled = !Num6Enable.Checked;

        }

        private void Num7Enable_CheckedChanged(object sender, EventArgs e)
        {
            if (Num7Text.Text.Length == 0)
            {
                Num7Enable.Checked = false;
            }
            Num7Text.Enabled = !Num7Enable.Checked;
        }

        private void Num8Enable_CheckedChanged(object sender, EventArgs e)
        {
            if (Num8Text.Text.Length == 0)
            {
                Num8Enable.Checked = false;
            }
            Num8Text.Enabled = !Num8Enable.Checked;

        }

        private void Num9Enable_CheckedChanged(object sender, EventArgs e)
        {
            if (Num9Text.Text.Length == 0)
            {
                Num9Enable.Checked = false;
            }
            Num9Text.Enabled = !Num9Enable.Checked;

        }
    }
}
