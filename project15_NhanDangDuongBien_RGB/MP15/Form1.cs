using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP15
{
    public partial class Form1 : Form
    {
        Bitmap hinhgoc = new Bitmap(@"D:\Machine_Vision\lena_goc.jpg");
        public Form1()
        {

            InitializeComponent();

            picORG.Image = hinhgoc;
        }
        public Bitmap sobelRGB(Bitmap Hinhgoc, byte nguong)
        {


            int[,] Sx =
            {
                {-1,-2,-1},
                { 0, 0, 0},
                { 1, 2, 1}
            };
            int[,] Sy =
            {
                {-1, 0, 1},
                {-2, 0, 2},
                {-1, 0, 1}
            };

            Bitmap edgedetect = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

            for (int x = 1; x < Hinhgoc.Width - 1; x++)
                for (int y = 1; y < Hinhgoc.Height - 1; y++)
                {
                    int gxx = 0, gyy = 0, gxy = 0, gxR = 0, gxG = 0, gxB = 0, gyR = 0, gyG = 0, gyB = 0;

                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = Hinhgoc.GetPixel(i, j);

                            int Gr = color.R;
                            int Gg = color.G;
                            int Gb = color.B;

                            gxR += Gr * Sx[i - x + 1, j - y + 1];

                            gyR += Gr * Sy[i - x + 1, j - y + 1];

                            gxG += Gg * Sx[i - x + 1, j - y + 1];

                            gyG += Gg * Sy[i - x + 1, j - y + 1];

                            gxB += Gb * Sx[i - x + 1, j - y + 1];

                            gyB += Gb * Sy[i - x + 1, j - y + 1];
                        }

                    gxx = (Math.Abs(gxR) * Math.Abs(gxR)) + (Math.Abs(gxG) * Math.Abs(gxG)) + (Math.Abs(gxB) * Math.Abs(gxB));
                    gyy = (Math.Abs(gyR) * Math.Abs(gyR)) + (Math.Abs(gyG) * Math.Abs(gyG)) + (Math.Abs(gyB) * Math.Abs(gyB));
                    gxy = ((gxR * gyR) + (gxG * gyG) + (gxB * gyB));

                    double theta = 0.5 * Math.Atan2((2 * gxy), (gxx - gyy));
                    double F0 = Math.Sqrt(0.5 * ((gxx + gyy) + (gxx - gyy) * Math.Cos(2 * theta) + 2 * gxy * Math.Sin(2 * theta)));
                    if ((byte)F0 < nguong)
                        edgedetect.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        edgedetect.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            return edgedetect;
        }
        public Bitmap sobelRGBver2(Bitmap Hinhgoc)
        {
            int Nguongdo = Convert.ToInt16(textBox1.Text);
            lblnum.Text = Nguongdo.ToString();
            int[,] Sx =
            {
                {-1,-2,-1},
                { 0, 0, 0},
                { 1, 2, 1}
            };
            int[,] Sy =
            {
                {-1, 0, 1},
                {-2, 0, 2},
                {-1, 0, 1}
            };

            Bitmap edgedetect = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);

            for (int x = 1; x < Hinhgoc.Width-1; x++)
                for (int y = 1; y < Hinhgoc.Height-1; y++)
                {
                    int gxx = 0, gxy = 0, gyy = 0, gxR = 0, gxG = 0, gxB = 0, gyR = 0, gyG = 0, gyB = 0;

                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = Hinhgoc.GetPixel(i, j);

                            int Gr = color.R;
                            int Gg = color.G;
                            int Gb = color.B;

                            gxR += Gr * Sx[i - x + 1, j - y + 1];

                            gyR += Gr * Sy[i - x + 1, j - y + 1];

                            gxG += Gg * Sx[i - x + 1, j - y + 1];

                            gyG += Gg * Sy[i - x + 1, j - y + 1];

                            gxB += Gb * Sx[i - x + 1, j - y + 1];

                            gyB += Gb * Sy[i - x + 1, j - y + 1];
                        }

                    gxx = (Math.Abs(gxR) * Math.Abs(gxR)) + (Math.Abs(gxG) * Math.Abs(gxG)) + (Math.Abs(gxB) * Math.Abs(gxB));
                    gyy = (Math.Abs(gyR) * Math.Abs(gyR)) + (Math.Abs(gyG) * Math.Abs(gyG)) + (Math.Abs(gyB) * Math.Abs(gyB));
                    gxy = ((gxR * gyR) + (gxG * gyG) + (gxB * gyB));

                    double theta = 0.5 * Math.Atan2((2 * gxy), (gxx - gyy));
                    double F0 = Math.Sqrt(0.5 * ((gxx + gyy) + (gxx - gyy) * Math.Cos(2 * theta) + 2 * gxy * Math.Sin(2 * theta)));
                    if ((byte)F0 < Nguongdo)
                        edgedetect.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        edgedetect.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            return edgedetect;
        }

        private void hSCRLedge_ValueChanged(object sender, EventArgs e)
        {
            byte nguong = (byte)hSCRLedge.Value;

            lblnum.Text = nguong.ToString();
            Bitmap duongbien = sobelRGB(hinhgoc, nguong);
            picSOB.Image = duongbien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap duongbien = sobelRGBver2(hinhgoc);

            picSOB.Image = duongbien;
        }

        private void hSCRLedge_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
