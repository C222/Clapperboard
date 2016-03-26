using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TwitchChatSharp;

namespace Clapperboard
{
    public partial class Clapperboard : Form
    {
        public TwitchConnection client;
        public string uname;

        public Clapperboard()
        {
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
            };
            client.Reconnected += (object sender, EventArgs e) =>
            {
                AppendDebugText("Reconnected");
            };
            client.MessageReceived += (object sender, IrcMessageEventArgs e) =>
            {
                HandleMessage(e.Message);
            };

        }

        private void HandleMessage(IrcMessage message)
        {
            if (message.User == uname || message.User == "tmi.twitch.tv" || message.User == uname+".tmi.twitch.tv")
            {
                return;
            }
            if (!CheckUser(message))
            {
                return;
            }
            AppendDebugText(message.User);
            AppendDebugText(message.Message);
            foreach (KeyValuePair<string, string> kvp in message.Tags)
            {
                AppendDebugText("K: " + kvp.Key +", V: "+ kvp.Value);
            }
            AppendDebugText("------------------------");
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
            if (this.DebugBox.InvokeRequired)
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
    }
}
