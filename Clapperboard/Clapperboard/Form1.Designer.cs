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
            this.Num7Box = new System.Windows.Forms.GroupBox();
            this.Num7Enable = new System.Windows.Forms.CheckBox();
            this.Num7Text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Num8Enable = new System.Windows.Forms.CheckBox();
            this.Num8Text = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Num9Enable = new System.Windows.Forms.CheckBox();
            this.Num9Text = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Num4Enable = new System.Windows.Forms.CheckBox();
            this.Num4Text = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Num5Enable = new System.Windows.Forms.CheckBox();
            this.Num5Text = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Num6Enable = new System.Windows.Forms.CheckBox();
            this.Num6Text = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Num1Enable = new System.Windows.Forms.CheckBox();
            this.Num1Text = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Num2Enable = new System.Windows.Forms.CheckBox();
            this.Num2Text = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Num3Enable = new System.Windows.Forms.CheckBox();
            this.Num3Text = new System.Windows.Forms.TextBox();
            this.LAlt = new System.Windows.Forms.CheckBox();
            this.LCtrl = new System.Windows.Forms.CheckBox();
            this.LShift = new System.Windows.Forms.CheckBox();
            this.Num7Box.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
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
            this.DebugBox.Size = new System.Drawing.Size(391, 288);
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
            this.YesMods.Location = new System.Drawing.Point(557, 12);
            this.YesMods.Name = "YesMods";
            this.YesMods.Size = new System.Drawing.Size(79, 17);
            this.YesMods.TabIndex = 6;
            this.YesMods.Text = "Moderators";
            this.YesMods.UseVisualStyleBackColor = true;
            // 
            // YesSubs
            // 
            this.YesSubs.AutoSize = true;
            this.YesSubs.Location = new System.Drawing.Point(557, 36);
            this.YesSubs.Name = "YesSubs";
            this.YesSubs.Size = new System.Drawing.Size(81, 17);
            this.YesSubs.TabIndex = 7;
            this.YesSubs.Text = "Subscribers";
            this.YesSubs.UseVisualStyleBackColor = true;
            // 
            // YesAll
            // 
            this.YesAll.AutoSize = true;
            this.YesAll.Location = new System.Drawing.Point(557, 60);
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
            this.SwitchTimeout.Location = new System.Drawing.Point(557, 96);
            this.SwitchTimeout.Name = "SwitchTimeout";
            this.SwitchTimeout.Size = new System.Drawing.Size(80, 21);
            this.SwitchTimeout.TabIndex = 9;
            this.SwitchTimeout.Text = "10";
            // 
            // TimeoutLabel
            // 
            this.TimeoutLabel.AutoSize = true;
            this.TimeoutLabel.Location = new System.Drawing.Point(557, 80);
            this.TimeoutLabel.Name = "TimeoutLabel";
            this.TimeoutLabel.Size = new System.Drawing.Size(80, 13);
            this.TimeoutLabel.TabIndex = 10;
            this.TimeoutLabel.Text = "Switch Timeout";
            // 
            // Num7Box
            // 
            this.Num7Box.Controls.Add(this.Num7Enable);
            this.Num7Box.Controls.Add(this.Num7Text);
            this.Num7Box.Location = new System.Drawing.Point(410, 126);
            this.Num7Box.Name = "Num7Box";
            this.Num7Box.Size = new System.Drawing.Size(72, 69);
            this.Num7Box.TabIndex = 11;
            this.Num7Box.TabStop = false;
            this.Num7Box.Text = "Num 7";
            // 
            // Num7Enable
            // 
            this.Num7Enable.AutoSize = true;
            this.Num7Enable.Location = new System.Drawing.Point(6, 19);
            this.Num7Enable.Name = "Num7Enable";
            this.Num7Enable.Size = new System.Drawing.Size(59, 17);
            this.Num7Enable.TabIndex = 4;
            this.Num7Enable.Text = "Enable";
            this.Num7Enable.UseVisualStyleBackColor = true;
            this.Num7Enable.CheckedChanged += new System.EventHandler(this.Num7Enable_CheckedChanged);
            // 
            // Num7Text
            // 
            this.Num7Text.Location = new System.Drawing.Point(6, 42);
            this.Num7Text.Name = "Num7Text";
            this.Num7Text.Size = new System.Drawing.Size(59, 20);
            this.Num7Text.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Num8Enable);
            this.groupBox1.Controls.Add(this.Num8Text);
            this.groupBox1.Location = new System.Drawing.Point(488, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(72, 69);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Num 8";
            // 
            // Num8Enable
            // 
            this.Num8Enable.AutoSize = true;
            this.Num8Enable.Location = new System.Drawing.Point(6, 19);
            this.Num8Enable.Name = "Num8Enable";
            this.Num8Enable.Size = new System.Drawing.Size(59, 17);
            this.Num8Enable.TabIndex = 4;
            this.Num8Enable.Text = "Enable";
            this.Num8Enable.UseVisualStyleBackColor = true;
            this.Num8Enable.CheckedChanged += new System.EventHandler(this.Num8Enable_CheckedChanged);
            // 
            // Num8Text
            // 
            this.Num8Text.Location = new System.Drawing.Point(6, 42);
            this.Num8Text.Name = "Num8Text";
            this.Num8Text.Size = new System.Drawing.Size(59, 20);
            this.Num8Text.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Num9Enable);
            this.groupBox2.Controls.Add(this.Num9Text);
            this.groupBox2.Location = new System.Drawing.Point(566, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(72, 69);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Num 9";
            // 
            // Num9Enable
            // 
            this.Num9Enable.AutoSize = true;
            this.Num9Enable.Location = new System.Drawing.Point(6, 19);
            this.Num9Enable.Name = "Num9Enable";
            this.Num9Enable.Size = new System.Drawing.Size(59, 17);
            this.Num9Enable.TabIndex = 4;
            this.Num9Enable.Text = "Enable";
            this.Num9Enable.UseVisualStyleBackColor = true;
            this.Num9Enable.CheckedChanged += new System.EventHandler(this.Num9Enable_CheckedChanged);
            // 
            // Num9Text
            // 
            this.Num9Text.Location = new System.Drawing.Point(6, 42);
            this.Num9Text.Name = "Num9Text";
            this.Num9Text.Size = new System.Drawing.Size(59, 20);
            this.Num9Text.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Num4Enable);
            this.groupBox3.Controls.Add(this.Num4Text);
            this.groupBox3.Location = new System.Drawing.Point(410, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(72, 69);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Num 4";
            // 
            // Num4Enable
            // 
            this.Num4Enable.AutoSize = true;
            this.Num4Enable.Location = new System.Drawing.Point(6, 19);
            this.Num4Enable.Name = "Num4Enable";
            this.Num4Enable.Size = new System.Drawing.Size(59, 17);
            this.Num4Enable.TabIndex = 4;
            this.Num4Enable.Text = "Enable";
            this.Num4Enable.UseVisualStyleBackColor = true;
            this.Num4Enable.CheckedChanged += new System.EventHandler(this.Num4Enable_CheckedChanged);
            // 
            // Num4Text
            // 
            this.Num4Text.Location = new System.Drawing.Point(6, 42);
            this.Num4Text.Name = "Num4Text";
            this.Num4Text.Size = new System.Drawing.Size(59, 20);
            this.Num4Text.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Num5Enable);
            this.groupBox4.Controls.Add(this.Num5Text);
            this.groupBox4.Location = new System.Drawing.Point(488, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(72, 69);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Num 5";
            // 
            // Num5Enable
            // 
            this.Num5Enable.AutoSize = true;
            this.Num5Enable.Location = new System.Drawing.Point(6, 19);
            this.Num5Enable.Name = "Num5Enable";
            this.Num5Enable.Size = new System.Drawing.Size(59, 17);
            this.Num5Enable.TabIndex = 4;
            this.Num5Enable.Text = "Enable";
            this.Num5Enable.UseVisualStyleBackColor = true;
            this.Num5Enable.CheckedChanged += new System.EventHandler(this.Num5Enable_CheckedChanged);
            // 
            // Num5Text
            // 
            this.Num5Text.Location = new System.Drawing.Point(6, 42);
            this.Num5Text.Name = "Num5Text";
            this.Num5Text.Size = new System.Drawing.Size(59, 20);
            this.Num5Text.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Num6Enable);
            this.groupBox5.Controls.Add(this.Num6Text);
            this.groupBox5.Location = new System.Drawing.Point(566, 201);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(72, 69);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Num 6";
            // 
            // Num6Enable
            // 
            this.Num6Enable.AutoSize = true;
            this.Num6Enable.Location = new System.Drawing.Point(6, 19);
            this.Num6Enable.Name = "Num6Enable";
            this.Num6Enable.Size = new System.Drawing.Size(59, 17);
            this.Num6Enable.TabIndex = 4;
            this.Num6Enable.Text = "Enable";
            this.Num6Enable.UseVisualStyleBackColor = true;
            this.Num6Enable.CheckedChanged += new System.EventHandler(this.Num6Enable_CheckedChanged);
            // 
            // Num6Text
            // 
            this.Num6Text.Location = new System.Drawing.Point(6, 42);
            this.Num6Text.Name = "Num6Text";
            this.Num6Text.Size = new System.Drawing.Size(59, 20);
            this.Num6Text.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Num1Enable);
            this.groupBox6.Controls.Add(this.Num1Text);
            this.groupBox6.Location = new System.Drawing.Point(410, 276);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(72, 69);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Num 1";
            // 
            // Num1Enable
            // 
            this.Num1Enable.AutoSize = true;
            this.Num1Enable.Location = new System.Drawing.Point(6, 19);
            this.Num1Enable.Name = "Num1Enable";
            this.Num1Enable.Size = new System.Drawing.Size(59, 17);
            this.Num1Enable.TabIndex = 4;
            this.Num1Enable.Text = "Enable";
            this.Num1Enable.UseVisualStyleBackColor = true;
            this.Num1Enable.CheckedChanged += new System.EventHandler(this.Num1Enable_CheckedChanged);
            // 
            // Num1Text
            // 
            this.Num1Text.Location = new System.Drawing.Point(6, 42);
            this.Num1Text.Name = "Num1Text";
            this.Num1Text.Size = new System.Drawing.Size(59, 20);
            this.Num1Text.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Num2Enable);
            this.groupBox7.Controls.Add(this.Num2Text);
            this.groupBox7.Location = new System.Drawing.Point(488, 276);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(72, 69);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Num 2";
            // 
            // Num2Enable
            // 
            this.Num2Enable.AutoSize = true;
            this.Num2Enable.Location = new System.Drawing.Point(6, 19);
            this.Num2Enable.Name = "Num2Enable";
            this.Num2Enable.Size = new System.Drawing.Size(59, 17);
            this.Num2Enable.TabIndex = 4;
            this.Num2Enable.Text = "Enable";
            this.Num2Enable.UseVisualStyleBackColor = true;
            this.Num2Enable.CheckedChanged += new System.EventHandler(this.Num2Enable_CheckedChanged);
            // 
            // Num2Text
            // 
            this.Num2Text.Location = new System.Drawing.Point(6, 42);
            this.Num2Text.Name = "Num2Text";
            this.Num2Text.Size = new System.Drawing.Size(59, 20);
            this.Num2Text.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Num3Enable);
            this.groupBox8.Controls.Add(this.Num3Text);
            this.groupBox8.Location = new System.Drawing.Point(566, 276);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(72, 69);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Num 3";
            // 
            // Num3Enable
            // 
            this.Num3Enable.AutoSize = true;
            this.Num3Enable.Location = new System.Drawing.Point(6, 19);
            this.Num3Enable.Name = "Num3Enable";
            this.Num3Enable.Size = new System.Drawing.Size(59, 17);
            this.Num3Enable.TabIndex = 4;
            this.Num3Enable.Text = "Enable";
            this.Num3Enable.UseVisualStyleBackColor = true;
            this.Num3Enable.CheckedChanged += new System.EventHandler(this.Num3Enable_CheckedChanged);
            // 
            // Num3Text
            // 
            this.Num3Text.Location = new System.Drawing.Point(6, 42);
            this.Num3Text.Name = "Num3Text";
            this.Num3Text.Size = new System.Drawing.Size(59, 20);
            this.Num3Text.TabIndex = 0;
            // 
            // LAlt
            // 
            this.LAlt.AutoSize = true;
            this.LAlt.Location = new System.Drawing.Point(411, 103);
            this.LAlt.Name = "LAlt";
            this.LAlt.Size = new System.Drawing.Size(44, 17);
            this.LAlt.TabIndex = 13;
            this.LAlt.Text = "LAlt";
            this.LAlt.UseVisualStyleBackColor = true;
            // 
            // LCtrl
            // 
            this.LCtrl.AutoSize = true;
            this.LCtrl.Location = new System.Drawing.Point(411, 80);
            this.LCtrl.Name = "LCtrl";
            this.LCtrl.Size = new System.Drawing.Size(47, 17);
            this.LCtrl.TabIndex = 14;
            this.LCtrl.Text = "LCtrl";
            this.LCtrl.UseVisualStyleBackColor = true;
            // 
            // LShift
            // 
            this.LShift.AutoSize = true;
            this.LShift.Location = new System.Drawing.Point(410, 60);
            this.LShift.Name = "LShift";
            this.LShift.Size = new System.Drawing.Size(53, 17);
            this.LShift.TabIndex = 15;
            this.LShift.Text = "LShift";
            this.LShift.UseVisualStyleBackColor = true;
            // 
            // Clapperboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 356);
            this.Controls.Add(this.LShift);
            this.Controls.Add(this.LCtrl);
            this.Controls.Add(this.LAlt);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Num7Box);
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
            this.Num7Box.ResumeLayout(false);
            this.Num7Box.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
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
        private System.Windows.Forms.GroupBox Num7Box;
        private System.Windows.Forms.CheckBox Num7Enable;
        private System.Windows.Forms.TextBox Num7Text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Num8Enable;
        private System.Windows.Forms.TextBox Num8Text;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Num9Enable;
        private System.Windows.Forms.TextBox Num9Text;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Num4Enable;
        private System.Windows.Forms.TextBox Num4Text;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox Num5Enable;
        private System.Windows.Forms.TextBox Num5Text;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox Num6Enable;
        private System.Windows.Forms.TextBox Num6Text;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox Num1Enable;
        private System.Windows.Forms.TextBox Num1Text;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox Num2Enable;
        private System.Windows.Forms.TextBox Num2Text;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox Num3Enable;
        private System.Windows.Forms.TextBox Num3Text;
        private System.Windows.Forms.CheckBox LAlt;
        private System.Windows.Forms.CheckBox LCtrl;
        private System.Windows.Forms.CheckBox LShift;
    }
}

