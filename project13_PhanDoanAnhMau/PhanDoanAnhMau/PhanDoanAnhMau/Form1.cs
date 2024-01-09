using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanDoanAnhMau
{
    public partial class Form1 : Form
    {

        //Load hình gốc cô gái Lena
        Bitmap Hinhgoc = new Bitmap(@"D:\Machine_Vision\lena_goc.jpg");

        public Form1()
        {

            InitializeComponent();

            //Hiển thị hình gốc 
            picBoxHinhGoc.Image = Hinhgoc;


        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ các textBox và chuyển từ kiểu ký tự sang kiểu số nguyên
            int Threshold = Convert.ToInt16(textBoxNguong.Text);
            int x1 = Convert.ToInt16(textBoxX1.Text);
            int y1 = Convert.ToInt16(textBoxY1.Text);
            int x2 = Convert.ToInt16(textBoxX2.Text);
            int y2 = Convert.ToInt16(textBoxY2.Text);

            double aR_TB = 0, aG_TB = 0, aB_TB = 0;

            //Tính vector màu TB
            //Lấy trung bình màu của các điểm ảnh trong vùng được chọn
            //từ x1 - x2 và từ y1 - y2
            for (int x = x1; x <= x2; x++)
                for (int y = y1; y <= y2; y++)
                {
                    Color pixel1 = Hinhgoc.GetPixel(x, y);
                    aR_TB += pixel1.R;
                    aG_TB += pixel1.G;
                    aB_TB += pixel1.B;

                }
            //Tại mỗi kênh R-G-B tiến hành tính TB cộng tất cả các điểm ảnh (pixel) thuộc vùng ảnh đã chọn ở trên

            double Size = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);
            aR_TB /= Size;
            aG_TB /= Size;
            aB_TB /= Size;
            //Nếu khoảng cách nhỏ hơn hoặc bằng ngưỡng, điểm ảnh đó sẽ được coi là phần nền
            //và được đặt là màu trắng. Nếu không nó giữ màu gốc của nó.

            //Phân đoạn ảnh
            //Tạo 1 ảnh bitmap chứa hình segmentation
            Bitmap SegmentationIMG = new Bitmap(Hinhgoc.Width, Hinhgoc.Height);
            //Vector z : điểm ảnh tại vị trí (x, y) đang muốn tính xem là điểm thuộc nền (background) hay thuộc đối tượng (object)
            for (int x = 0; x < Hinhgoc.Width; x++)
                for (int y = 0; y < Hinhgoc.Height; y++)
                {
                    //// Lấy màu của điểm ảnh hiện tại
                    Color pixel2 = Hinhgoc.GetPixel(x, y);
                    double zR = pixel2.R;
                    double zG = pixel2.G;
                    double zB = pixel2.B;

                    //// Tính khoảng cách màu từ điểm ảnh hiện tại đến trung bình màu
                    //CT 6.7-1 : D(z,a) = SQRT[(zR - aR)^2 + (zG - aG)^2 + (zB - aB)^2]
                    double D = Math.Sqrt(Math.Pow(zR - aR_TB, 2) + Math.Pow(zG - aG_TB, 2) + Math.Pow(zB - aB_TB, 2));

                    //So sánh với GT ngưỡng (threshold) để xác định xem điểm z(x,y) đang xét là background hay object
                    //Nếu khoảng cách nhỏ hơn hoặc bằng ngưỡng, điểm ảnh đó sẽ được coi là phần nền
                    //và được đặt là màu trắng. Nếu không nó giữ màu gốc của nó.
                    if ((int)D <= Threshold)
                        SegmentationIMG.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    else
                        SegmentationIMG.SetPixel(x, y, Color.FromArgb((int)zR, (int)zG, (int)zB));

                }
            //Hiển thị ảnh đã phân đoạn
            picBoxSegmentation.Image = SegmentationIMG;
        }
    }
}
