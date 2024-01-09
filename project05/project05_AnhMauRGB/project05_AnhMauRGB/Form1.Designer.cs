namespace project05_AnhMauRGB
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
            this.picBoxAnhMauRGB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zGHistogram = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnhMauRGB)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxAnhMauRGB
            // 
            this.picBoxAnhMauRGB.Location = new System.Drawing.Point(12, 46);
            this.picBoxAnhMauRGB.Name = "picBoxAnhMauRGB";
            this.picBoxAnhMauRGB.Size = new System.Drawing.Size(300, 200);
            this.picBoxAnhMauRGB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAnhMauRGB.TabIndex = 0;
            this.picBoxAnhMauRGB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình gốc:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // zGHistogram
            // 
            this.zGHistogram.Location = new System.Drawing.Point(330, 46);
            this.zGHistogram.Name = "zGHistogram";
            this.zGHistogram.ScrollGrace = 0D;
            this.zGHistogram.ScrollMaxX = 0D;
            this.zGHistogram.ScrollMaxY = 0D;
            this.zGHistogram.ScrollMaxY2 = 0D;
            this.zGHistogram.ScrollMinX = 0D;
            this.zGHistogram.ScrollMinY = 0D;
            this.zGHistogram.ScrollMinY2 = 0D;
            this.zGHistogram.Size = new System.Drawing.Size(600, 400);
            this.zGHistogram.TabIndex = 2;
            this.zGHistogram.UseExtendedPrintDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 498);
            this.Controls.Add(this.zGHistogram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxAnhMauRGB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnhMauRGB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAnhMauRGB;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl zGHistogram;
    }
}

