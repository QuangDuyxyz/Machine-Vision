namespace project05
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
            this.picBoxHinhGoc = new System.Windows.Forms.PictureBox();
            this.picBoxHinhMucXam = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zGHistogram = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhMucXam)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHinhGoc
            // 
            this.picBoxHinhGoc.Location = new System.Drawing.Point(36, 33);
            this.picBoxHinhGoc.Name = "picBoxHinhGoc";
            this.picBoxHinhGoc.Size = new System.Drawing.Size(300, 200);
            this.picBoxHinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhGoc.TabIndex = 0;
            this.picBoxHinhGoc.TabStop = false;
            // 
            // picBoxHinhMucXam
            // 
            this.picBoxHinhMucXam.Location = new System.Drawing.Point(36, 281);
            this.picBoxHinhMucXam.Name = "picBoxHinhMucXam";
            this.picBoxHinhMucXam.Size = new System.Drawing.Size(300, 200);
            this.picBoxHinhMucXam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhMucXam.TabIndex = 1;
            this.picBoxHinhMucXam.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hình gốc:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hình mức xám:";
            // 
            // zGHistogram
            // 
            this.zGHistogram.Location = new System.Drawing.Point(342, 33);
            this.zGHistogram.Name = "zGHistogram";
            this.zGHistogram.ScrollGrace = 0D;
            this.zGHistogram.ScrollMaxX = 0D;
            this.zGHistogram.ScrollMaxY = 0D;
            this.zGHistogram.ScrollMaxY2 = 0D;
            this.zGHistogram.ScrollMinX = 0D;
            this.zGHistogram.ScrollMinY = 0D;
            this.zGHistogram.ScrollMinY2 = 0D;
            this.zGHistogram.Size = new System.Drawing.Size(600, 400);
            this.zGHistogram.TabIndex = 4;
            this.zGHistogram.UseExtendedPrintDialog = true;
            this.zGHistogram.Load += new System.EventHandler(this.zGHistogram_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 507);
            this.Controls.Add(this.zGHistogram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxHinhMucXam);
            this.Controls.Add(this.picBoxHinhGoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhMucXam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHinhGoc;
        private System.Windows.Forms.PictureBox picBoxHinhMucXam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ZedGraph.ZedGraphControl zGHistogram;
    }
}

