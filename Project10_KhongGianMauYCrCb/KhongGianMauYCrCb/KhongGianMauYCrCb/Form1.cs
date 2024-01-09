using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhongGianMauYCrCb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Load và hiển thị hình gốc lên img1_RGB 
            Bitmap Original = new Bitmap(@"D:\Machine_Vision\Lena_goc.jpg");
            picBoxHinhGoc.Image = Original;

            List<Bitmap> YCrCb = Convert_YCrCb(Original);

            picBoxY.Image = YCrCb[0];
            picBoxCr.Image = YCrCb[1];
            picBoxCb.Image = YCrCb[2];
            picBoxYCrCb.Image = YCrCb[3];
        }


        public List<Bitmap> Convert_YCrCb(Bitmap Original)
        {
            //Tạo mảng động LIST chứa các KQ sau khi chuyển đổi
            List<Bitmap> YCrCb = new List<Bitmap>();

            //Tạo 3 kênh màu chứa hình các kênh Y-Cr-Cb
            Bitmap YIMG = new Bitmap(Original.Width, Original.Height);
            Bitmap CrIMG = new Bitmap(Original.Width, Original.Height);
            Bitmap CbIMG = new Bitmap(Original.Width, Original.Height);

            //Tạo hình YCrCb = kết hợp 3 kênh Y-Cr-Cb
            Bitmap YCrCb_IMG = new Bitmap(Original.Width, Original.Height);

            //Quét từng điểm ảnh có trong hình và quét cột theo cột
            for (int x = 0; x < Original.Width; x++)
                for (int y = 0; y < Original.Height; y++)
                {
                    //Lấy thông tin điểm ảnh tại vị trí (x,y)
                    Color pixel = Original.GetPixel(x, y);

                    //Ở các dạng trước ta dùng kiểu Byte cho R-G-B
                    //Tuy nhiên, do quá trình tính toán YCrCb thì KQ trả về là kiểu Double (số thực) nên ta dùng kiểu Double
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    //Tính Y-Cr-Cb
                    double Y = (16 + (65.738 * R) / 256 + (129.057 * G) / 256 + (25.064 * B) / 256);
                    double Cr = (128 - (37.945 * R) / 256 - (74.494 * G) / 256 + (112.439 * B) / 256);
                    double Cb = (128 + (112.439 * R) / 256 - (94.154 * G) / 256 - (18.285 * B) / 256);


                    //Hiển thị các kênh giá trị Y-Cr-Cb
                    //Lưu ý : phải ép kiểu của Y-Cr-Cb về kiểu Byte thì Bitmap mới hiểu và hiện thị được
                    YIMG.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Y, (byte)Y));
                    CrIMG.SetPixel(x, y, Color.FromArgb((byte)Cr, (byte)Cr, (byte)Cr));
                    CbIMG.SetPixel(x, y, Color.FromArgb((byte)Cb, (byte)Cb, (byte)Cb));

                    //Hiển thị kênh giá trị tổng hợp YCrCb
                    YCrCb_IMG.SetPixel(x, y, Color.FromArgb((byte)Y, (byte)Cr, (byte)Cb));

                }

            YCrCb.Add(YIMG);
            YCrCb.Add(CrIMG);
            YCrCb.Add(CbIMG);
            YCrCb.Add(YCrCb_IMG);

            return YCrCb;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
