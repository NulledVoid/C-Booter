namespace RIPBooter
{
    partial class Booter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booter));
            this.MainFRM = new Teen.ThirteenForm();
            this.LabelOne = new System.Windows.Forms.Label();
            this.DDOSLog = new Teen.ThirteenTextBox();
            this.Target = new Teen.ThirteenTextBox();
            this.DDOSButton = new Teen.ThirteenButton();
            this.ControlFRM = new Teen.ThirteenControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeBox = new Teen.ThirteenTextBox();
            this.PortBox = new Teen.ThirteenTextBox();
            this.Port = new System.Windows.Forms.Label();
            this.MethodCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.MainFRM.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFRM
            // 
            this.MainFRM.AccentColor = System.Drawing.Color.Yellow;
            this.MainFRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MainFRM.ColorScheme = Teen.ThirteenForm.ColorSchemes.Dark;
            this.MainFRM.Controls.Add(this.linkLabel1);
            this.MainFRM.Controls.Add(this.label3);
            this.MainFRM.Controls.Add(this.MethodCombo);
            this.MainFRM.Controls.Add(this.Port);
            this.MainFRM.Controls.Add(this.PortBox);
            this.MainFRM.Controls.Add(this.TimeBox);
            this.MainFRM.Controls.Add(this.label2);
            this.MainFRM.Controls.Add(this.label1);
            this.MainFRM.Controls.Add(this.LabelOne);
            this.MainFRM.Controls.Add(this.DDOSLog);
            this.MainFRM.Controls.Add(this.Target);
            this.MainFRM.Controls.Add(this.DDOSButton);
            this.MainFRM.Controls.Add(this.ControlFRM);
            this.MainFRM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFRM.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.MainFRM.ForeColor = System.Drawing.Color.White;
            this.MainFRM.Location = new System.Drawing.Point(0, 0);
            this.MainFRM.Name = "MainFRM";
            this.MainFRM.Size = new System.Drawing.Size(284, 325);
            this.MainFRM.TabIndex = 0;
            this.MainFRM.Text = "Booter Template by Static";
            // 
            // LabelOne
            // 
            this.LabelOne.AutoSize = true;
            this.LabelOne.Location = new System.Drawing.Point(104, 42);
            this.LabelOne.Name = "LabelOne";
            this.LabelOne.Size = new System.Drawing.Size(70, 17);
            this.LabelOne.TabIndex = 4;
            this.LabelOne.Text = "DDOS Log:";
            // 
            // DDOSLog
            // 
            this.DDOSLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DDOSLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DDOSLog.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.DDOSLog.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.DDOSLog.ForeColor = System.Drawing.Color.White;
            this.DDOSLog.Location = new System.Drawing.Point(8, 62);
            this.DDOSLog.Multiline = true;
            this.DDOSLog.Name = "DDOSLog";
            this.DDOSLog.ReadOnly = true;
            this.DDOSLog.Size = new System.Drawing.Size(269, 118);
            this.DDOSLog.TabIndex = 3;
            this.DDOSLog.Text = "Please Note:\r\nYou have to edit the application for it to not crash and add the\r\nD" +
    "DoS API URL In the Booter.cs FRM.\r\nThank you for using NulledVoids (Static\'s) Bo" +
    "oter Template.\r\nEnjoy.\r\n";
            this.DDOSLog.TextChanged += new System.EventHandler(this.thirteenTextBox2_TextChanged);
            // 
            // Target
            // 
            this.Target.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Target.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Target.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.Target.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.Target.ForeColor = System.Drawing.Color.White;
            this.Target.Location = new System.Drawing.Point(14, 251);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(111, 25);
            this.Target.TabIndex = 2;
            // 
            // DDOSButton
            // 
            this.DDOSButton.AccentColor = System.Drawing.Color.Yellow;
            this.DDOSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DDOSButton.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.DDOSButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.DDOSButton.ForeColor = System.Drawing.Color.White;
            this.DDOSButton.Location = new System.Drawing.Point(167, 282);
            this.DDOSButton.Name = "DDOSButton";
            this.DDOSButton.Size = new System.Drawing.Size(111, 38);
            this.DDOSButton.TabIndex = 1;
            this.DDOSButton.Text = "L4 ATTACK";
            this.DDOSButton.UseVisualStyleBackColor = false;
            this.DDOSButton.Click += new System.EventHandler(this.DDOSButton_Click);
            // 
            // ControlFRM
            // 
            this.ControlFRM.AccentColor = System.Drawing.Color.Yellow;
            this.ControlFRM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlFRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ControlFRM.ColorScheme = Teen.ThirteenControlBox.ColorSchemes.Dark;
            this.ControlFRM.ForeColor = System.Drawing.Color.White;
            this.ControlFRM.Location = new System.Drawing.Point(181, 3);
            this.ControlFRM.Name = "ControlFRM";
            this.ControlFRM.Size = new System.Drawing.Size(100, 25);
            this.ControlFRM.TabIndex = 0;
            this.ControlFRM.Text = "control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Target";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time";
            // 
            // TimeBox
            // 
            this.TimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TimeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeBox.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.TimeBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.TimeBox.ForeColor = System.Drawing.Color.White;
            this.TimeBox.Location = new System.Drawing.Point(14, 203);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(111, 25);
            this.TimeBox.TabIndex = 7;
            // 
            // PortBox
            // 
            this.PortBox.AcceptsReturn = true;
            this.PortBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PortBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PortBox.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.PortBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.PortBox.ForeColor = System.Drawing.Color.White;
            this.PortBox.Location = new System.Drawing.Point(167, 203);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(111, 25);
            this.PortBox.TabIndex = 8;
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(208, 183);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(30, 17);
            this.Port.TabIndex = 9;
            this.Port.Text = "Port";
            // 
            // MethodCombo
            // 
            this.MethodCombo.FormattingEnabled = true;
            this.MethodCombo.Items.AddRange(new object[] {
            "UDP",
            "TCP",
            "STD"});
            this.MethodCombo.Location = new System.Drawing.Point(167, 251);
            this.MethodCombo.Name = "MethodCombo";
            this.MethodCombo.Size = new System.Drawing.Size(111, 25);
            this.MethodCombo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Method";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(8, 300);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Created by NulledVoid";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Booter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 325);
            this.Controls.Add(this.MainFRM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Booter";
            this.Text = "Booter";
            this.MainFRM.ResumeLayout(false);
            this.MainFRM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Teen.ThirteenForm MainFRM;
        private Teen.ThirteenTextBox Target;
        private Teen.ThirteenButton DDOSButton;
        private Teen.ThirteenControlBox ControlFRM;
        private Teen.ThirteenTextBox DDOSLog;
        private System.Windows.Forms.Label LabelOne;
        private Teen.ThirteenTextBox TimeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Port;
        private Teen.ThirteenTextBox PortBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MethodCombo;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

