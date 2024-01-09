namespace XLA_project01RGB
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
            this.picBox_HinhGoc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox_GREEN = new System.Windows.Forms.PictureBox();
            this.picBox_RED = new System.Windows.Forms.PictureBox();
            this.picBox_BLUE = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_GREEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_RED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_BLUE)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_HinhGoc
            // 
            this.picBox_HinhGoc.Location = new System.Drawing.Point(62, 27);
            this.picBox_HinhGoc.Name = "picBox_HinhGoc";
            this.picBox_HinhGoc.Size = new System.Drawing.Size(220, 220);
            this.picBox_HinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_HinhGoc.TabIndex = 0;
            this.picBox_HinhGoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kênh màu Gốc";
            // 
            // picBox_GREEN
            // 
            this.picBox_GREEN.Location = new System.Drawing.Point(62, 278);
            this.picBox_GREEN.Name = "picBox_GREEN";
            this.picBox_GREEN.Size = new System.Drawing.Size(220, 220);
            this.picBox_GREEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_GREEN.TabIndex = 2;
            this.picBox_GREEN.TabStop = false;
            // 
            // picBox_RED
            // 
            this.picBox_RED.Location = new System.Drawing.Point(390, 27);
            this.picBox_RED.Name = "picBox_RED";
            this.picBox_RED.Size = new System.Drawing.Size(333, 220);
            this.picBox_RED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_RED.TabIndex = 3;
            this.picBox_RED.TabStop = false;
            // 
            // picBox_BLUE
            // 
            this.picBox_BLUE.Location = new System.Drawing.Point(390, 278);
            this.picBox_BLUE.Name = "picBox_BLUE";
            this.picBox_BLUE.Size = new System.Drawing.Size(220, 220);
            this.picBox_BLUE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_BLUE.TabIndex = 4;
            this.picBox_BLUE.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kênh màu RED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kênh màu BLUE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kênh màu GREEN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox_BLUE);
            this.Controls.Add(this.picBox_RED);
            this.Controls.Add(this.picBox_GREEN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_HinhGoc);
            this.Name = "Form1";
            this.Text = "Hiển thị hình ảnh RGB RED-GREEN-BLUE";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_GREEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_RED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_BLUE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_HinhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox_GREEN;
        private System.Windows.Forms.PictureBox picBox_RED;
        private System.Windows.Forms.PictureBox picBox_BLUE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

