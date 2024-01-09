namespace TachAnhMauXam
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
            this.picBoxHinhXamGoc = new System.Windows.Forms.PictureBox();
            this.picBoxHinhXamLightness = new System.Windows.Forms.PictureBox();
            this.picBoxHinhXamAverage = new System.Windows.Forms.PictureBox();
            this.picBoxHinhXamLuminance = new System.Windows.Forms.PictureBox();
            this.lblHinhGoc = new System.Windows.Forms.Label();
            this.lblHinhMauXamLightness = new System.Windows.Forms.Label();
            this.lblHinhMauxamAverage = new System.Windows.Forms.Label();
            this.lblHinhMauXamLuminance = new System.Windows.Forms.Label();
            this.picBoxHinhNhiPhan = new System.Windows.Forms.PictureBox();
            this.lblHinhNhiPhan = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBarHinhNhiPhan = new System.Windows.Forms.VScrollBar();
            this.lblNguong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhXamGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhXamLightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhXamAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhXamLuminance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhNhiPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHinhXamGoc
            // 
            this.picBoxHinhXamGoc.Location = new System.Drawing.Point(36, 88);
            this.picBoxHinhXamGoc.Name = "picBoxHinhXamGoc";
            this.picBoxHinhXamGoc.Size = new System.Drawing.Size(200, 200);
            this.picBoxHinhXamGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhXamGoc.TabIndex = 0;
            this.picBoxHinhXamGoc.TabStop = false;
            // 
            // picBoxHinhXamLightness
            // 
            this.picBoxHinhXamLightness.Location = new System.Drawing.Point(327, 88);
            this.picBoxHinhXamLightness.Name = "picBoxHinhXamLightness";
            this.picBoxHinhXamLightness.Size = new System.Drawing.Size(200, 200);
            this.picBoxHinhXamLightness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhXamLightness.TabIndex = 1;
            this.picBoxHinhXamLightness.TabStop = false;
            // 
            // picBoxHinhXamAverage
            // 
            this.picBoxHinhXamAverage.Location = new System.Drawing.Point(36, 349);
            this.picBoxHinhXamAverage.Name = "picBoxHinhXamAverage";
            this.picBoxHinhXamAverage.Size = new System.Drawing.Size(200, 200);
            this.picBoxHinhXamAverage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhXamAverage.TabIndex = 2;
            this.picBoxHinhXamAverage.TabStop = false;
            // 
            // picBoxHinhXamLuminance
            // 
            this.picBoxHinhXamLuminance.Location = new System.Drawing.Point(327, 349);
            this.picBoxHinhXamLuminance.Name = "picBoxHinhXamLuminance";
            this.picBoxHinhXamLuminance.Size = new System.Drawing.Size(200, 200);
            this.picBoxHinhXamLuminance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhXamLuminance.TabIndex = 3;
            this.picBoxHinhXamLuminance.TabStop = false;
            // 
            // lblHinhGoc
            // 
            this.lblHinhGoc.AutoSize = true;
            this.lblHinhGoc.Location = new System.Drawing.Point(33, 55);
            this.lblHinhGoc.Name = "lblHinhGoc";
            this.lblHinhGoc.Size = new System.Drawing.Size(50, 13);
            this.lblHinhGoc.TabIndex = 4;
            this.lblHinhGoc.Text = "Hinh gốc";
            // 
            // lblHinhMauXamLightness
            // 
            this.lblHinhMauXamLightness.AutoSize = true;
            this.lblHinhMauXamLightness.Location = new System.Drawing.Point(324, 55);
            this.lblHinhMauXamLightness.Name = "lblHinhMauXamLightness";
            this.lblHinhMauXamLightness.Size = new System.Drawing.Size(119, 13);
            this.lblHinhMauXamLightness.TabIndex = 5;
            this.lblHinhMauXamLightness.Text = "Phương pháp Lightness";
            // 
            // lblHinhMauxamAverage
            // 
            this.lblHinhMauxamAverage.AutoSize = true;
            this.lblHinhMauxamAverage.Location = new System.Drawing.Point(33, 316);
            this.lblHinhMauxamAverage.Name = "lblHinhMauxamAverage";
            this.lblHinhMauxamAverage.Size = new System.Drawing.Size(114, 13);
            this.lblHinhMauxamAverage.TabIndex = 6;
            this.lblHinhMauxamAverage.Text = "Phương pháp Average";
            // 
            // lblHinhMauXamLuminance
            // 
            this.lblHinhMauXamLuminance.AutoSize = true;
            this.lblHinhMauXamLuminance.Location = new System.Drawing.Point(324, 316);
            this.lblHinhMauXamLuminance.Name = "lblHinhMauXamLuminance";
            this.lblHinhMauXamLuminance.Size = new System.Drawing.Size(126, 13);
            this.lblHinhMauXamLuminance.TabIndex = 7;
            this.lblHinhMauXamLuminance.Text = "Phương pháp Luminance";
            this.lblHinhMauXamLuminance.Click += new System.EventHandler(this.lblHinhMauXamLuminance_Click);
            // 
            // picBoxHinhNhiPhan
            // 
            this.picBoxHinhNhiPhan.Location = new System.Drawing.Point(608, 88);
            this.picBoxHinhNhiPhan.Name = "picBoxHinhNhiPhan";
            this.picBoxHinhNhiPhan.Size = new System.Drawing.Size(200, 200);
            this.picBoxHinhNhiPhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhNhiPhan.TabIndex = 8;
            this.picBoxHinhNhiPhan.TabStop = false;
            // 
            // lblHinhNhiPhan
            // 
            this.lblHinhNhiPhan.AutoSize = true;
            this.lblHinhNhiPhan.Location = new System.Drawing.Point(605, 55);
            this.lblHinhNhiPhan.Name = "lblHinhNhiPhan";
            this.lblHinhNhiPhan.Size = new System.Drawing.Size(73, 13);
            this.lblHinhNhiPhan.TabIndex = 9;
            this.lblHinhNhiPhan.Text = "Hình nhị phân";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 10;
            // 
            // vScrollBarHinhNhiPhan
            // 
            this.vScrollBarHinhNhiPhan.Location = new System.Drawing.Point(847, 88);
            this.vScrollBarHinhNhiPhan.Maximum = 255;
            this.vScrollBarHinhNhiPhan.Name = "vScrollBarHinhNhiPhan";
            this.vScrollBarHinhNhiPhan.Size = new System.Drawing.Size(32, 200);
            this.vScrollBarHinhNhiPhan.TabIndex = 11;
            this.vScrollBarHinhNhiPhan.ValueChanged += new System.EventHandler(this.vScrollBarHinhNhiPhan_ValueChanged);
            // 
            // lblNguong
            // 
            this.lblNguong.AutoSize = true;
            this.lblNguong.Location = new System.Drawing.Point(844, 55);
            this.lblNguong.Name = "lblNguong";
            this.lblNguong.Size = new System.Drawing.Size(45, 13);
            this.lblNguong.TabIndex = 12;
            this.lblNguong.Text = "Ngưỡng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 561);
            this.Controls.Add(this.lblNguong);
            this.Controls.Add(this.vScrollBarHinhNhiPhan);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.lblHinhNhiPhan);
            this.Controls.Add(this.picBoxHinhNhiPhan);
            this.Controls.Add(this.lblHinhMauXamLuminance);
            this.Controls.Add(this.lblHinhMauxamAverage);
            this.Controls.Add(this.lblHinhMauXamLightness);
            this.Controls.Add(this.lblHinhGoc);
            this.Controls.Add(this.picBoxHinhXamLuminance);
            this.Controls.Add(this.picBoxHinhXamAverage);
            this.Controls.Add(this.picBoxHinhXamLightness);
            this.Controls.Add(this.picBoxHinhXamGoc);
            this.Name = "Form1";
            this.Text = "Hiển thị ảnh tách màu xám RGB";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhXamGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhXamLightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhXamAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhXamLuminance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhNhiPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHinhXamGoc;
        private System.Windows.Forms.PictureBox picBoxHinhXamLightness;
        private System.Windows.Forms.PictureBox picBoxHinhXamAverage;
        private System.Windows.Forms.PictureBox picBoxHinhXamLuminance;
        private System.Windows.Forms.Label lblHinhGoc;
        private System.Windows.Forms.Label lblHinhMauXamLightness;
        private System.Windows.Forms.Label lblHinhMauxamAverage;
        private System.Windows.Forms.Label lblHinhMauXamLuminance;
        private System.Windows.Forms.PictureBox picBoxHinhNhiPhan;
        private System.Windows.Forms.Label lblHinhNhiPhan;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBarHinhNhiPhan;
        private System.Windows.Forms.Label lblNguong;
    }
}

