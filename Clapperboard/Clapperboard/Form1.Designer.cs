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
            // Clapperboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
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
    }
}

