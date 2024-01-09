namespace MP15
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picORG = new System.Windows.Forms.PictureBox();
            this.picSOB = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hSCRLedge = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picORG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSOB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nguyen Quang Duy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "20146240";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ORG";
            // 
            // picORG
            // 
            this.picORG.Location = new System.Drawing.Point(114, 27);
            this.picORG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picORG.Name = "picORG";
            this.picORG.Size = new System.Drawing.Size(384, 416);
            this.picORG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picORG.TabIndex = 3;
            this.picORG.TabStop = false;
            // 
            // picSOB
            // 
            this.picSOB.Location = new System.Drawing.Point(502, 27);
            this.picSOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picSOB.Name = "picSOB";
            this.picSOB.Size = new System.Drawing.Size(384, 416);
            this.picSOB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSOB.TabIndex = 5;
            this.picSOB.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SOBEL";
            // 
            // hSCRLedge
            // 
            this.hSCRLedge.LargeChange = 1;
            this.hSCRLedge.Location = new System.Drawing.Point(114, 461);
            this.hSCRLedge.Maximum = 255;
            this.hSCRLedge.Name = "hSCRLedge";
            this.hSCRLedge.Size = new System.Drawing.Size(722, 21);
            this.hSCRLedge.TabIndex = 6;
            this.hSCRLedge.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSCRLedge_Scroll);
            this.hSCRLedge.ValueChanged += new System.EventHandler(this.hSCRLedge_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 488);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nguong: ";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(178, 488);
            this.lblnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(13, 13);
            this.lblnum.TabIndex = 8;
            this.lblnum.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 513);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 511);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hSCRLedge);
            this.Controls.Add(this.picSOB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picORG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "wo men bu yi yang";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picORG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSOB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picORG;
        private System.Windows.Forms.PictureBox picSOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar hSCRLedge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

