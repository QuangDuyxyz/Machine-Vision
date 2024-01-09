namespace NhanDangDuongBien
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
            this.picBoxHinhGoc = new System.Windows.Forms.PictureBox();
            this.picBoxSobel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.scroll_Nguong = new System.Windows.Forms.TrackBar();
            this.lb_Nguong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSobel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scroll_Nguong)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHinhGoc
            // 
            this.picBoxHinhGoc.Location = new System.Drawing.Point(16, 47);
            this.picBoxHinhGoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxHinhGoc.Name = "picBoxHinhGoc";
            this.picBoxHinhGoc.Size = new System.Drawing.Size(400, 369);
            this.picBoxHinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhGoc.TabIndex = 0;
            this.picBoxHinhGoc.TabStop = false;
            // 
            // picBoxSobel
            // 
            this.picBoxSobel.Location = new System.Drawing.Point(424, 47);
            this.picBoxSobel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxSobel.Name = "picBoxSobel";
            this.picBoxSobel.Size = new System.Drawing.Size(400, 369);
            this.picBoxSobel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSobel.TabIndex = 1;
            this.picBoxSobel.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hình màu RGB gốc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ảnh nhận dạng biên dùng Sobel:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(932, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 89);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nhận dạng biên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scroll_Nguong
            // 
            this.scroll_Nguong.LargeChange = 1;
            this.scroll_Nguong.Location = new System.Drawing.Point(139, 486);
            this.scroll_Nguong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scroll_Nguong.Maximum = 255;
            this.scroll_Nguong.Name = "scroll_Nguong";
            this.scroll_Nguong.Size = new System.Drawing.Size(685, 56);
            this.scroll_Nguong.TabIndex = 5;
            this.scroll_Nguong.ValueChanged += new System.EventHandler(this.scroll_Nguong_ValueChanged);
            // 
            // lb_Nguong
            // 
            this.lb_Nguong.AutoSize = true;
            this.lb_Nguong.Location = new System.Drawing.Point(16, 486);
            this.lb_Nguong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Nguong.Name = "lb_Nguong";
            this.lb_Nguong.Size = new System.Drawing.Size(58, 16);
            this.lb_Nguong.TabIndex = 6;
            this.lb_Nguong.Text = "Ngưỡng:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 610);
            this.Controls.Add(this.lb_Nguong);
            this.Controls.Add(this.scroll_Nguong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxSobel);
            this.Controls.Add(this.picBoxHinhGoc);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Edge Detection - Nhận dạng đường biên ảnh mức xám(Average) dùng phương pháp Sobel" +
    "";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSobel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scroll_Nguong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHinhGoc;
        private System.Windows.Forms.PictureBox picBoxSobel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar scroll_Nguong;
        private System.Windows.Forms.Label lb_Nguong;
    }
}

