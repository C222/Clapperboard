namespace Clapperboard
{
    partial class Clapperboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clapperboard));
            this.ChannelLabel = new System.Windows.Forms.Label();
            this.JoinButton = new System.Windows.Forms.Button();
            this.ChannelNameBox = new System.Windows.Forms.TextBox();
            this.DebugBox = new System.Windows.Forms.TextBox();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.YesMods = new System.Windows.Forms.CheckBox();
            this.YesSubs = new System.Windows.Forms.CheckBox();
            this.YesAll = new System.Windows.Forms.CheckBox();
            this.SwitchTimeout = new System.Windows.Forms.ComboBox();
            this.TimeoutLabel = new System.Windows.Forms.Label();
            this.Cmd1Box = new System.Windows.Forms.GroupBox();
            this.Cmd1Text = new System.Windows.Forms.TextBox();
            this.Cmd1Command = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmd1Enable = new System.Windows.Forms.CheckBox();
            this.Cmd1Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.Location = new System.Drawing.Point(13, 13);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(46, 13);
            this.ChannelLabel.TabIndex = 0;
            this.ChannelLabel.Text = "Channel";
            // 
            // JoinButton
            // 
            this.JoinButton.Location = new System.Drawing.Point(197, 27);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.Size = new System.Drawing.Size(75, 23);
            this.JoinButton.TabIndex = 1;
            this.JoinButton.Text = "Join";
            this.JoinButton.UseVisualStyleBackColor = true;
            this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // ChannelNameBox
            // 
            this.ChannelNameBox.Location = new System.Drawing.Point(13, 30);
            this.ChannelNameBox.Name = "ChannelNameBox";
            this.ChannelNameBox.Size = new System.Drawing.Size(178, 20);
            this.ChannelNameBox.TabIndex = 2;
            // 
            // DebugBox
            // 
            this.DebugBox.Location = new System.Drawing.Point(13, 57);
            this.DebugBox.Multiline = true;
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DebugBox.Size = new System.Drawing.Size(391, 493);
            this.DebugBox.TabIndex = 3;
            // 
            // LeaveButton
            // 
            this.LeaveButton.Enabled = false;
            this.LeaveButton.Location = new System.Drawing.Point(278, 27);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(75, 23);
            this.LeaveButton.TabIndex = 4;
            this.LeaveButton.Text = "Leave";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // YesMods
            // 
            this.YesMods.AutoSize = true;
            this.YesMods.Location = new System.Drawing.Point(692, 13);
            this.YesMods.Name = "YesMods";
            this.YesMods.Size = new System.Drawing.Size(79, 17);
            this.YesMods.TabIndex = 6;
            this.YesMods.Text = "Moderators";
            this.YesMods.UseVisualStyleBackColor = true;
            // 
            // YesSubs
            // 
            this.YesSubs.AutoSize = true;
            this.YesSubs.Location = new System.Drawing.Point(692, 37);
            this.YesSubs.Name = "YesSubs";
            this.YesSubs.Size = new System.Drawing.Size(81, 17);
            this.YesSubs.TabIndex = 7;
            this.YesSubs.Text = "Subscribers";
            this.YesSubs.UseVisualStyleBackColor = true;
            // 
            // YesAll
            // 
            this.YesAll.AutoSize = true;
            this.YesAll.Location = new System.Drawing.Point(692, 61);
            this.YesAll.Name = "YesAll";
            this.YesAll.Size = new System.Drawing.Size(71, 17);
            this.YesAll.TabIndex = 8;
            this.YesAll.Text = "Everyone";
            this.YesAll.UseVisualStyleBackColor = true;
            // 
            // SwitchTimeout
            // 
            this.SwitchTimeout.FormattingEnabled = true;
            this.SwitchTimeout.Items.AddRange(new object[] {
            "1",
            "10",
            "30",
            "60",
            "120",
            "180",
            "240",
            "300",
            "600"});
            this.SwitchTimeout.Location = new System.Drawing.Point(692, 97);
            this.SwitchTimeout.Name = "SwitchTimeout";
            this.SwitchTimeout.Size = new System.Drawing.Size(80, 21);
            this.SwitchTimeout.TabIndex = 9;
            this.SwitchTimeout.Text = "10";
            // 
            // TimeoutLabel
            // 
            this.TimeoutLabel.AutoSize = true;
            this.TimeoutLabel.Location = new System.Drawing.Point(692, 81);
            this.TimeoutLabel.Name = "TimeoutLabel";
            this.TimeoutLabel.Size = new System.Drawing.Size(80, 13);
            this.TimeoutLabel.TabIndex = 10;
            this.TimeoutLabel.Text = "Switch Timeout";
            // 
            // Cmd1Box
            // 
            this.Cmd1Box.Controls.Add(this.Cmd1Enable);
            this.Cmd1Box.Controls.Add(this.label2);
            this.Cmd1Box.Controls.Add(this.label1);
            this.Cmd1Box.Controls.Add(this.Cmd1Command);
            this.Cmd1Box.Controls.Add(this.Cmd1Text);
            this.Cmd1Box.Location = new System.Drawing.Point(410, 124);
            this.Cmd1Box.Name = "Cmd1Box";
            this.Cmd1Box.Size = new System.Drawing.Size(362, 64);
            this.Cmd1Box.TabIndex = 11;
            this.Cmd1Box.TabStop = false;
            this.Cmd1Box.Text = "Command 1";
            // 
            // Cmd1Text
            // 
            this.Cmd1Text.Location = new System.Drawing.Point(5, 35);
            this.Cmd1Text.Name = "Cmd1Text";
            this.Cmd1Text.Size = new System.Drawing.Size(100, 20);
            this.Cmd1Text.TabIndex = 0;
            // 
            // Cmd1Command
            // 
            this.Cmd1Command.Location = new System.Drawing.Point(111, 35);
            this.Cmd1Command.Name = "Cmd1Command";
            this.Cmd1Command.Size = new System.Drawing.Size(244, 20);
            this.Cmd1Command.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Command";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key Combo";
            // 
            // Cmd1Enable
            // 
            this.Cmd1Enable.AutoSize = true;
            this.Cmd1Enable.Location = new System.Drawing.Point(297, 15);
            this.Cmd1Enable.Name = "Cmd1Enable";
            this.Cmd1Enable.Size = new System.Drawing.Size(59, 17);
            this.Cmd1Enable.TabIndex = 4;
            this.Cmd1Enable.Text = "Enable";
            this.Cmd1Enable.UseVisualStyleBackColor = true;
            this.Cmd1Enable.CheckedChanged += new System.EventHandler(this.Cmd1Enable_CheckedChanged);
            // 
            // Clapperboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.Cmd1Box);
            this.Controls.Add(this.TimeoutLabel);
            this.Controls.Add(this.SwitchTimeout);
            this.Controls.Add(this.YesAll);
            this.Controls.Add(this.YesSubs);
            this.Controls.Add(this.YesMods);
            this.Controls.Add(this.LeaveButton);
            this.Controls.Add(this.DebugBox);
            this.Controls.Add(this.ChannelNameBox);
            this.Controls.Add(this.JoinButton);
            this.Controls.Add(this.ChannelLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clapperboard";
            this.Text = "Clapperboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Cmd1Box.ResumeLayout(false);
            this.Cmd1Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChannelLabel;
        private System.Windows.Forms.Button JoinButton;
        private System.Windows.Forms.TextBox ChannelNameBox;
        private System.Windows.Forms.TextBox DebugBox;
        private System.Windows.Forms.Button LeaveButton;
        private System.Windows.Forms.CheckBox YesMods;
        private System.Windows.Forms.CheckBox YesSubs;
        private System.Windows.Forms.CheckBox YesAll;
        private System.Windows.Forms.ComboBox SwitchTimeout;
        private System.Windows.Forms.Label TimeoutLabel;
        private System.Windows.Forms.GroupBox Cmd1Box;
        private System.Windows.Forms.CheckBox Cmd1Enable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cmd1Command;
        private System.Windows.Forms.TextBox Cmd1Text;
    }
}

