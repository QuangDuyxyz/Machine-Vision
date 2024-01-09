using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TachAnhMauXam
{
    public partial class Form1 : Form
    {
        Bitmap HinhGoc;
        public Form1()
        {
            InitializeComponent();
            // Load hình .jpg từ đường dẫn tới tập tin hình ảnh
            //Chuyển biến này thành toàn cục (global) để sử dụng cho các hàm khác
            HinhGoc = new Bitmap(@"C:\Users\Qduy\Desktop\Machine_Vision\Lena_goc.PNG");

            // Hiển thị hình gốc trên pictureBox
            picBoxHinhXamGoc.Image = HinhGoc;

            // Chuyển đổi và hiển thị hình ảnh sang mức xám theo phương pháp Lightness
            picBoxHinhXamLightness.Image = ChuyenHinhRGBSangHinhXamLightness(HinhGoc);

            // Chuyển đổi và hiển thị hình ảnh sang mức xám theo phương pháp Average
            picBoxHinhXamAverage.Image = ChuyenHinhRGBSangHinhXamAverage(HinhGoc);

            // Chuyển đổi và hiển thị hình ảnh sang mức xám theo phương pháp Luminance
            picBoxHinhXamLuminance.Image = ChuyenHinhRGBSangHinhXamLuminance(HinhGoc);

            // Tính hình nhị phân và cho hiển thị
            // Giả sử cho ngưỡng là 100
            picBoxHinhNhiPhan.Image = ChuyenHinhRGBSangHinhNhiPhan(HinhGoc, 100);
        }

        /// <summary>
        /// Hàm chuyển đổi hình ảnh từ màu RGB sang mức xám theo phương pháp Lightness
        /// </summary>
        /// <param name="hinhgoc">Hình ảnh gốc</param>
        /// <returns>Hình ảnh mức xám</returns>
        private Bitmap ChuyenHinhRGBSangHinhXamLightness(Bitmap hinhgoc)
        {
            Bitmap HinhMucXam = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            //Duyệt qua từng hàng và từng cột  của hình ảnh
            for (int x = 0; x < hinhgoc.Width; x++)
            {
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Lấy điểm ảnh từ hình ảnh gốc tại (x, y)
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // Tính giá trị mức xám bằng phương pháp Lightness
                    int grayValue = (Math.Max(R, Math.Max(G, B)) + Math.Min(R, Math.Min(G, B))) / 2;

                    // Đặt giá trị mức xám cho điểm ảnh tại (x, y) trong hình ảnh mức xám
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue));
                }
            }

            return HinhMucXam;
        }

        /// <summary>
        /// Hàm chuyển đổi hình ảnh từ màu RGB sang mức xám theo phương pháp Average
        /// </summary>
        /// <param name="hinhgoc">Hình ảnh gốc</param>
        /// <returns>Hình ảnh mức xám</returns>
        private Bitmap ChuyenHinhRGBSangHinhXamAverage(Bitmap hinhgoc)
        {
            Bitmap HinhMucXam = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            //Duyệt qua từng hàng và từng cột  của hình ảnh
            for (int x = 0; x < hinhgoc.Width; x++)
            {
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Lấy điểm ảnh từ hình ảnh gốc tại (x, y)
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // Tính giá trị mức xám bằng phương pháp Average
                    int grayValue = (R + G + B) / 3;

                    // Đặt giá trị mức xám cho điểm ảnh tại (x, y) trong hình ảnh mức xám
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue));
                }
            }

            return HinhMucXam;
        }

        /// <summary>
        /// Hàm chuyển đổi hình ảnh từ màu RGB sang mức xám theo phương pháp Luminance
        /// </summary>
        /// <param name="hinhgoc">Hình ảnh gốc</param>
        /// <returns>Hình ảnh mức xám</returns>
        private Bitmap ChuyenHinhRGBSangHinhXamLuminance(Bitmap hinhgoc)
        {
            Bitmap HinhMucXam = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            //Duyệt qua từng hàng và từng cột  của hình ảnh
            for (int x = 0; x < hinhgoc.Width; x++)
            {
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Lấy màu cuả điểm ảnh từ hình ảnh gốc tại (x, y)
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // Tính giá trị mức xám bằng phương pháp Luminance
                    int grayValue = (int)(0.299 * R + 0.587 * G + 0.114 * B);

                    // Đặt giá trị mức xám cho điểm ảnh tại (x, y) trong hình ảnh mức xám
                    HinhMucXam.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue));
                }
            }

            return HinhMucXam;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hinhgoc"></param>
        /// <param name="nguong"></param>
        /// <returns></returns>
        private Bitmap ChuyenHinhRGBSangHinhNhiPhan(Bitmap hinhgoc, byte nguong)
        {
            Bitmap HinhNhiPhan = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            //Duyệt qua từng hàng và từng cột  của hình ảnh
            for (int x = 0; x < hinhgoc.Width; x++)
            {
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Lấy màu cuả điểm ảnh từ hình ảnh gốc tại (x, y)
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // Tính giá trị mức xám bằng phương pháp Luminance
                    int nhiphan = (int)(0.299 * R + 0.587 * G + 0.114 * B);

                    // phân loại điểm ảnh sang nhị phân dựa vào giá trị ngưỡng
                    if (nhiphan < nguong)
                        nhiphan  = 0;
                    else
                        nhiphan = 255;

                   
                    // Đặt giá trị mức xám cho điểm ảnh tại (x, y) trong hình ảnh mức xám
                    HinhNhiPhan.SetPixel(x, y, Color.FromArgb(nhiphan, nhiphan, nhiphan));
                }
            }

            return HinhNhiPhan;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblHinhMauXamLuminance_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBarHinhNhiPhan_ValueChanged(object sender, EventArgs e)
        {
            // Lấy giá trị ngưỡng từ giá trị của thanh cuộn
            //Do value của thanh cuộn trả về int, nhưng ngưỡng là kiểu byte
            //Cần phải ép kiểu int về byte

            byte nguong = (byte)vScrollBarHinhNhiPhan.Value;

            //Cho hiển thị giá trị ngưỡng
            lblNguong.Text = nguong.ToString();

            // Gọi hàm tính ảnh nhị phân và cho hiển thị
            picBoxHinhNhiPhan.Image = ChuyenHinhRGBSangHinhNhiPhan(HinhGoc, nguong);
            
        }
    }
}
