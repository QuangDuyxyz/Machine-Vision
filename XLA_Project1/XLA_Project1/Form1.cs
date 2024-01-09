using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace XLA_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Tạo một biến chứa đường dẫn lưu hình RGB gốc
            // Có kí tự @ phía trước đường dẫn để C#.NET hiểu là chuỗi Unicode để không bị báo lỗi
            string filehinh = @"C:\Users\Qduy\Downloads\Lena_goc.png";

            // Đọc hình ảnh từ đường dẫn
            Bitmap originalImage = new Bitmap(filehinh);
            // Hiển thị hình ảnh gốc trong picBox_Original
            picBox_HinhGoc.Image = originalImage;

            // Tạo các biến để lưu các lớp màu Red, Green và Blue
            Bitmap redLayer = new Bitmap(originalImage.Width, originalImage.Height);
            Bitmap greenLayer = new Bitmap(originalImage.Width, originalImage.Height);
            Bitmap blueLayer = new Bitmap(originalImage.Width, originalImage.Height);

            // Lặp qua từng điểm ảnh và tách thành các lớp màu
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);

                    // Lấy giá trị Red, Green và Blue từ điểm ảnh
                    int redValue = pixelColor.R;
                    int greenValue = pixelColor.G;
                    int blueValue = pixelColor.B;

                    // Tạo màu mới với một trong các thành phần màu bằng 0
                    Color redColor = Color.FromArgb(redValue, 0, 0);
                    Color greenColor = Color.FromArgb(0, greenValue, 0);
                    Color blueColor = Color.FromArgb(0, 0, blueValue);

                    // Gán giá trị màu vào từng điểm ảnh trong các lớp màu tương ứng
                    redLayer.SetPixel(x, y, redColor);
                    greenLayer.SetPixel(x, y, greenColor);
                    blueLayer.SetPixel(x, y, blueColor);
                }
            }

            // Hiển thị các lớp màu trong các hình ảnh
            picBox_HinhRED.Image = redLayer;
            picBox_HinhXanhLa.Image = greenLayer;
            picBox_HinhNuocBien.Image = blueLayer;
        }
    }
}

