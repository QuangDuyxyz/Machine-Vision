using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap HinhGoc = new Bitmap(@"C:\Users\Qduy\Desktop\Machine_Vision\Lena_goc.PNG");
            // Cho hiển thị trên pictureBox
            picBoxHinhGoc.Image = HinhGoc;

            // Hiển thị các kênh màu CMYK được chuyển đổi từ RGB
            // Gọi hàm chuyển đổi RGB sang CMYK
            List<Bitmap> CMYK = ChuyenDoiRGBSangCMYK(HinhGoc);

            // Hàm trên trả về 4 màu tương ứng thứ tự từ 0-3 là C-M-Y-K
            // Hiển thị trên pictureBox
            picBoxC.Image = CMYK[0];  // Kênh màu Cyan
            picBoxM.Image = CMYK[1];  // Kênh màu Magenta
            picBoxY.Image = CMYK[2];  // Kênh màu Yellow
            picBoxB.Image = CMYK[3];  // Kênh màu Black
        }

        public List<Bitmap> ChuyenDoiRGBSangCMYK(Bitmap hinhgoc)
        {
            // Màu Cyan (xanh dương) là sự kết hợp giữa Green và Blue, nên set Red = 0
            // Màu Magenta (tím) là sự kết hợp giữa Red và Blue, nên set Green = 0
            // Màu Yellow (vàng) là sự kết hợp của Red và Green, nên set Blue = 0
            // Màu Black (đen) là min(R, G, B)

            // Tạo một List để chứa 4 kênh ảnh tương ứng C-M-Y-K
            List<Bitmap> CMYK = new List<Bitmap>();

            // Tạo 4 hình Bitmap bằng với kích thước hình gốc, để việc tính toán
            // chuyển đổi kênh màu được thực hiện đúng cho từng pixel
            // Mỗi kênh trong không gian màu CMYK được hiển thị bởi một hình bitmap
            Bitmap Cyan = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Magenta = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Yellow = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            Bitmap Black = new Bitmap(hinhgoc.Width, hinhgoc.Height);

            // Mình tiến hành quét ảnh gốc, 2 vòng lặp for này giúp duyệt qua từng điểm ảnh theo từng hàng, cột
            for (int x = 0; x < hinhgoc.Width; x++)
            
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Lấy điểm ảnh
                    Color pixel = hinhgoc.GetPixel(x, y);
                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;

                    // Màu Cyan (Xanh dương)
                    Cyan.SetPixel(x, y, Color.FromArgb(0, G, B));
                    // Màu Magenta (tím)
                    Magenta.SetPixel(x, y, Color.FromArgb(R, 0, B));
                    // Màu Yellow (vàng)
                    Yellow.SetPixel(x, y, Color.FromArgb(R, G, 0));
                    // Màu Black (đen)
                    byte K = Math.Min(R, Math.Min(G, B));
                    Black.SetPixel(x, y, Color.FromArgb(K, K, K));
                }
            

            // Add các hình tương ứng các kênh màu C-M-Y-K vào list
            CMYK.Add(Cyan);
            CMYK.Add(Magenta);
            CMYK.Add(Yellow);
            CMYK.Add(Black);

            // Hàm trả về 4 ảnh bitmap tương ứng 4 kênh màu C-M-Y-K
            return CMYK;
        }
    }
}
