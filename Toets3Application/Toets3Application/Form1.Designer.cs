namespace Toets3Application
{
    partial class Form1
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblConnection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbThrows = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThrow = new System.Windows.Forms.Button();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.nudAm = new System.Windows.Forms.NumericUpDown();
            this.cbDie = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(128, 47);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(146, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(128, 47);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.BackColor = System.Drawing.Color.Red;
            this.lblConnection.Location = new System.Drawing.Point(12, 62);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(262, 65);
            this.lblConnection.TabIndex = 8;
            this.lblConnection.Text = "Disconnected";
            this.lblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // lbThrows
            // 
            this.lbThrows.FormattingEnabled = true;
            this.lbThrows.ItemHeight = 16;
            this.lbThrows.Location = new System.Drawing.Point(461, 247);
            this.lbThrows.Name = "lbThrows";
            this.lbThrows.Size = new System.Drawing.Size(200, 260);
            this.lbThrows.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnThrow);
            this.groupBox1.Controls.Add(this.cbMode);
            this.groupBox1.Controls.Add(this.nudAm);
            this.groupBox1.Controls.Add(this.cbDie);
            this.groupBox1.Location = new System.Drawing.Point(280, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 229);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Throw selector";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Die Select:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mode:";
            // 
            // btnThrow
            // 
            this.btnThrow.Location = new System.Drawing.Point(247, 136);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(128, 47);
            this.btnThrow.TabIndex = 17;
            this.btnThrow.Text = "Throw";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // cbMode
            // 
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Advantage",
            "Normaal",
            "Disadvantage"});
            this.cbMode.Location = new System.Drawing.Point(110, 163);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(121, 24);
            this.cbMode.TabIndex = 2;
            // 
            // nudAm
            // 
            this.nudAm.Location = new System.Drawing.Point(111, 109);
            this.nudAm.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudAm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAm.Name = "nudAm";
            this.nudAm.Size = new System.Drawing.Size(120, 22);
            this.nudAm.TabIndex = 1;
            this.nudAm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbDie
            // 
            this.cbDie.Location = new System.Drawing.Point(111, 50);
            this.cbDie.Name = "cbDie";
            this.cbDie.Size = new System.Drawing.Size(121, 24);
            this.cbDie.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbThrows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Die Thrower";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbThrows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThrow;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.NumericUpDown nudAm;
        private System.Windows.Forms.ComboBox cbDie;
    }
}

