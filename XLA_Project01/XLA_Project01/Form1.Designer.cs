namespace XLA_Project01
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
            this.components = new System.ComponentModel.Container();
            this.imgBox_HienThiHinh = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_HienThiHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox_HienThiHinh
            // 
            this.imgBox_HienThiHinh.Location = new System.Drawing.Point(58, 37);
            this.imgBox_HienThiHinh.Name = "imgBox_HienThiHinh";
            this.imgBox_HienThiHinh.Size = new System.Drawing.Size(512, 512);
            this.imgBox_HienThiHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox_HienThiHinh.TabIndex = 2;
            this.imgBox_HienThiHinh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hiển thị hình:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nguyễn Quang Duy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "20146240";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgBox_HienThiHinh);
            this.Name = "Form1";
            this.Text = "Hiển thị ảnh PNG";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_HienThiHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgBox_HienThiHinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

