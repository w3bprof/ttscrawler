namespace ZetaCrawler
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkBIDV = new System.Windows.Forms.CheckBox();
            this.chkMp3Zing = new System.Windows.Forms.CheckBox();
            this.chkASPNET = new System.Windows.Forms.CheckBox();
            this.chkNewsletter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(735, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Timer";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interval";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(629, 19);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(100, 20);
            this.txtInterval.TabIndex = 2;
            this.txtInterval.Text = "5000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contacts";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(462, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "taipm@bidc.vn; phanminhtaihoaitan@yahoo.com";
            // 
            // chkBIDV
            // 
            this.chkBIDV.AutoSize = true;
            this.chkBIDV.Location = new System.Drawing.Point(82, 60);
            this.chkBIDV.Name = "chkBIDV";
            this.chkBIDV.Size = new System.Drawing.Size(51, 17);
            this.chkBIDV.TabIndex = 5;
            this.chkBIDV.Text = "BIDV";
            this.chkBIDV.UseVisualStyleBackColor = true;
            this.chkBIDV.CheckedChanged += new System.EventHandler(this.chkBIDV_CheckedChanged);
            // 
            // chkMp3Zing
            // 
            this.chkMp3Zing.AutoSize = true;
            this.chkMp3Zing.Location = new System.Drawing.Point(166, 60);
            this.chkMp3Zing.Name = "chkMp3Zing";
            this.chkMp3Zing.Size = new System.Drawing.Size(68, 17);
            this.chkMp3Zing.TabIndex = 6;
            this.chkMp3Zing.Text = "Mp3Zing";
            this.chkMp3Zing.UseVisualStyleBackColor = true;
            this.chkMp3Zing.CheckedChanged += new System.EventHandler(this.chkMp3Zing_CheckedChanged);
            // 
            // chkASPNET
            // 
            this.chkASPNET.AutoSize = true;
            this.chkASPNET.Location = new System.Drawing.Point(272, 60);
            this.chkASPNET.Name = "chkASPNET";
            this.chkASPNET.Size = new System.Drawing.Size(72, 17);
            this.chkASPNET.TabIndex = 7;
            this.chkASPNET.Text = "ASP.NET";
            this.chkASPNET.UseVisualStyleBackColor = true;
            this.chkASPNET.CheckedChanged += new System.EventHandler(this.chkASPNET_CheckedChanged);
            // 
            // chkNewsletter
            // 
            this.chkNewsletter.AutoSize = true;
            this.chkNewsletter.Location = new System.Drawing.Point(366, 60);
            this.chkNewsletter.Name = "chkNewsletter";
            this.chkNewsletter.Size = new System.Drawing.Size(76, 17);
            this.chkNewsletter.TabIndex = 8;
            this.chkNewsletter.Text = "Newsletter";
            this.chkNewsletter.UseVisualStyleBackColor = true;
            this.chkNewsletter.CheckedChanged += new System.EventHandler(this.chkNewsletter_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 264);
            this.Controls.Add(this.chkNewsletter);
            this.Controls.Add(this.chkASPNET);
            this.Controls.Add(this.chkMp3Zing);
            this.Controls.Add(this.chkBIDV);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkBIDV;
        private System.Windows.Forms.CheckBox chkMp3Zing;
        private System.Windows.Forms.CheckBox chkASPNET;
        private System.Windows.Forms.CheckBox chkNewsletter;
    }
}

