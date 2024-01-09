using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project07_KGMRGBSangHSI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Load hình .jpg từ file. Dùng hình màu RGb chuẩn Lena Girl
            Bitmap HinhGoc = new Bitmap(@"C:\Users\Qduy\Desktop\Machine_Vision\Lena_goc.jpg");
            //Hiển thị hình gốc lên picBox.
            picBoxHinhGoc.Image = HinhGoc;
            //Hàm chuyển đổi RGB sang HSI
            List<Bitmap> HSI = ChuyenDoiRGBSangHSI(HinhGoc);

            //Sau đó thì cho hiển thị kết quả.
            picBoxH.Image = HSI[0];
            picBoxS.Image = HSI[1];
            picBoxI.Image = HSI[2];
            picBoxHSI.Image = HSI[3];
        }
        // Hàm chuyển đổi RGB sang HSI
        public List<Bitmap> ChuyenDoiRGBSangHSI(Bitmap hinhgoc)
        {
            // Tạo mảng động LIST chứa các hình kết quả sau chuyển đổi
            List<Bitmap> HSI = new List<Bitmap>();
            //Tạo 3 kênh màu để chứa hình của các kênh H-S-I
            Bitmap Hue = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Saturation = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Intensity = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            //Đây là hình HSI (Kết hợp cả 3 kênh H-S-I)
            Bitmap HSIImg = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            //Tiến hành quét từng điểm ảnh có trong hình
            for (int x = 0; x < hinhgoc.Width; x++)
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    //Lấy thông tin điểm ảnh tại vị trí (x,y)
                    Color pixel = hinhgoc.GetPixel(x, y);

                    //Ở các dạng trước ta dùng kiểu Byte cho R-G-B
                    //Tuy nhiên, do quá trình tính toán HSI thì KQ trả về là kiểu Double (số thực) nên ta dùng kiểu Double
                    double R = pixel.R;
                    double G = pixel.G;
                    double B = pixel.B;

                    /*=====================================TÍNH GÓC THETA=====================================*/
                    //Tử số
                    double t1 = ((R - G) + (R - B)) / 2;
                    //Mẫu số
                    double t2 = Math.Sqrt((R - G) * (R - G) + (R - B) * (G - B));
                    //Theta
                    //Lưu ý : theo công thức là Độ. Nhưng trong C#.NET là Radian
                    double theta = Math.Acos(t1 / t2);

                    /*=====================================TÍNH GIÁ TRỊ HUE=====================================*/
                    double H = 0;
                    //TH1 : Nếu Blue <= Green thì Hue = theta
                    if (B <= G)
                    {
                        H = theta;

                    }
                    //TH2 : Nếu Blue > Green thì Hue được tính như sau : 
                    else
                    {
                        H = 2 * (Math.PI) - theta;
                        //Đổi ra Độ
                        H = (H * 180) / Math.PI;

                    }

                    //TÍNH GIÁ TRỊ SATURATION
                    double S = 1 - 3 * Math.Min(R, Math.Min(G, B)) / (R + G + B);

                    //TÍNH GIÁ TRỊ INTENSITY
                    //Nhìn tương tự như RGB sang GrayScale
                    double I = (R + G + B) / 3;


                    //Cho hiển thị các kênh giá trị H-S-I tại các picBox
                    //Ép kiểu cùa các giá trị H-S-I về kiểu byte để Bitmap hiểu và hiển thị.
                    Hue.SetPixel(x, y, Color.FromArgb((byte)H, (byte)H, (byte)H));
                    //Riêng giá trị S, mình có thể normalized như (1)
                    //hoặc mình có thể chỉ normalized lúc hiển thị
                    Saturation.SetPixel(x, y, Color.FromArgb((byte)(S * 255), (byte)(S * 255), (byte)(S * 255)));
                    Intensity.SetPixel(x, y, Color.FromArgb((byte)I, (byte)I, (byte)I));
                    //Còn giá trị gốc của kênh S chưa Normalized mình có thể dùng để kết hợp
                    //các kênh H & I để tạo thành HSI
                    HSIImg.SetPixel(x, y, Color.FromArgb((byte)H, (byte)S, (byte)I));
                }
            //Ở trên mình có khai báo tạo một mảng động để chứa kết quả các hình trả về sau chuyển đổi
            HSI.Add(Hue);
            HSI.Add(Saturation);
            HSI.Add(Intensity);
            HSI.Add(HSIImg);

            //Trả mảng hình kết quả sau chuyển đổi
            return HSI;

        }
    }
}
