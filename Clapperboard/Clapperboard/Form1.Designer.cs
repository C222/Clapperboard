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
            this.DebugBox.Size = new System.Drawing.Size(259, 193);
            this.DebugBox.TabIndex = 3;
            // 
            // Clapperboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
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
    }
}

