using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanDangDuongBien
{
    public partial class Form1 : Form
    {
        //Load hình gốc cô gái Lena
        Bitmap Hinhgoc = new Bitmap(@"C:\Users\ACER\Documents\machine vision\lena_color.jpg");

        public Form1()
        {
            InitializeComponent();
            //Hiển thị hình gốc lên im1_Original
            picBoxHinhGoc.Image = Hinhgoc;
        }
        public Bitmap LuminanceIMG(Bitmap Original)
        {
            Bitmap GrayScale = new Bitmap(Original.Width, Original.Height);
            for (int x = 0; x < Original.Width; x++)
                for (int y = 0; y < Original.Height; y++)
                {
                    //Lấy điểm ảnh tại (x,y)
                    Color pixel = Original.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    //Giá trị mức xám điểm ảnh tại (x,y)
                    byte Gray = (byte)(0.2126 * R + 0.7152 * G + 0.0722 * B);

                    //Gán gray vào hình mức xám
                    GrayScale.SetPixel(x, y, Color.FromArgb(Gray, Gray, Gray));

                }
            return GrayScale;
        }

        public Bitmap SobelIMG(Bitmap Grayscale, byte Nguong)
        {
            int[,] MTSobelx =
            {
                {-1, -2, -1},
                {0, 0, 0},
                {1, 2, 1 },
            };
            int[,] MTSobely =
            {
                {-1, 0, 1 },
                {-2, 0, 2 },
                {-1, 0, 1 },
            };
            Bitmap AnhDuongBien = new Bitmap(Grayscale.Width, Grayscale.Height);
            for (int x = 1; x < Grayscale.Width - 1; x++)
                for (int y = 1; y < Grayscale.Height - 1; y++)
                {
                    int gx = 0, gy = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = Grayscale.GetPixel(i, j);
                            int gR = color.R;
                            gx += gR * MTSobelx[i - x + 1, j - y + 1];
                            gy += gR * MTSobely[i - x + 1, j - y + 1];

                        }
                    int M = Math.Abs(gx) + Math.Abs(gy);
                    if ((byte)M < Nguong)
                        AnhDuongBien.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        AnhDuongBien.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            return AnhDuongBien;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Lấy GT ngưỡng từ thanh cuộn
            //Do value của thanh cuộn là kiểu int, trong khi ngưỡng là kiểu Byte
            //Do đó phải chuyển từ Int về Byte
            
        }

        private void scroll_Nguong_ValueChanged(object sender, EventArgs e)
        {
            byte Nguong = (byte)scroll_Nguong.Value;

            //Hiển thị Gt ngưỡng
            scroll_Nguong.Text = Nguong.ToString();
            Bitmap GrayScale = LuminanceIMG(Hinhgoc);
            Bitmap AnhDuongBien = SobelIMG(GrayScale, Nguong);
            picBoxSobel.Image = AnhDuongBien;
        }
    }
    
}
