namespace XLA_Project1
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
            this.picBox_HinhRED = new System.Windows.Forms.PictureBox();
            this.picBox_HinhXanhLa = new System.Windows.Forms.PictureBox();
            this.picBox_HinhNuocBien = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhRED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhXanhLa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhNuocBien)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_HinhGoc
            // 
            this.picBox_HinhGoc.Location = new System.Drawing.Point(67, 39);
            this.picBox_HinhGoc.Name = "picBox_HinhGoc";
            this.picBox_HinhGoc.Size = new System.Drawing.Size(200, 200);
            this.picBox_HinhGoc.TabIndex = 0;
            this.picBox_HinhGoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kênh màu gốc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picBox_HinhRED
            // 
            this.picBox_HinhRED.Location = new System.Drawing.Point(433, 39);
            this.picBox_HinhRED.Name = "picBox_HinhRED";
            this.picBox_HinhRED.Size = new System.Drawing.Size(200, 200);
            this.picBox_HinhRED.TabIndex = 2;
            this.picBox_HinhRED.TabStop = false;
            // 
            // picBox_HinhXanhLa
            // 
            this.picBox_HinhXanhLa.Location = new System.Drawing.Point(433, 291);
            this.picBox_HinhXanhLa.Name = "picBox_HinhXanhLa";
            this.picBox_HinhXanhLa.Size = new System.Drawing.Size(200, 200);
            this.picBox_HinhXanhLa.TabIndex = 3;
            this.picBox_HinhXanhLa.TabStop = false;
            // 
            // picBox_HinhNuocBien
            // 
            this.picBox_HinhNuocBien.Location = new System.Drawing.Point(700, 158);
            this.picBox_HinhNuocBien.Name = "picBox_HinhNuocBien";
            this.picBox_HinhNuocBien.Size = new System.Drawing.Size(200, 200);
            this.picBox_HinhNuocBien.TabIndex = 4;
            this.picBox_HinhNuocBien.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kênh màu xanh lá  ( GREEN )";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kênh màu đỏ( RED )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kênh màu xanh nước biển( BLUE )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox_HinhNuocBien);
            this.Controls.Add(this.picBox_HinhXanhLa);
            this.Controls.Add(this.picBox_HinhRED);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_HinhGoc);
            this.Name = "Form1";
            this.Text = "Hiển Thị Hình Thành 3 Lớp (RED-GREEN-BLUE)";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhRED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhXanhLa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhNuocBien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_HinhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox_HinhRED;
        private System.Windows.Forms.PictureBox picBox_HinhXanhLa;
        private System.Windows.Forms.PictureBox picBox_HinhNuocBien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

