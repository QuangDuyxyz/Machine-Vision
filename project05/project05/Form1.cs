using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace project05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Load hình .jpg từ file
            Bitmap HinhGoc = new Bitmap(@"C:\Users\Qduy\Desktop\Machine_Vision\bird_small.jpg");

            // Cho hiển thị trên pictureBox
            picBoxHinhGoc.Image = HinhGoc;

            // Tính hình mức xám theo phương pháp Luminance và cho hiển thị
            Bitmap HinhMucXam = ChuyenHinhRGBSangHinhXamLuminance(HinhGoc);
            picBoxHinhMucXam.Image = HinhMucXam;

            // BÂY GIỜ GỌI CÁC HÀM ĐÃ VIẾT ĐỂ VẼ BIỂU ĐỒ HISTOGRAM

            // Tính histogram
            double[] histogram = TinhHistogram(HinhMucXam);

            // Chuyển đổi kiểu dữ liệu.
            PointPairList points = ChuyenDoiHistogram(histogram);

            // Vẽ biểu đồ histogram và cho hiển thị.
            zGHistogram.GraphPane = BieuDoHistogram(points);
            zGHistogram.Refresh();
        }

        /// <summary>
        /// Khai báo hàm tính mức xám theo phương pháp ĐỘ SÁNG TUYẾN TÍNH ( LINEAR LUMINANCE )
        /// </summary>
        /// <param name="hinhgoc"></param>
        /// <returns></returns>
        private Bitmap ChuyenHinhRGBSangHinhXamLuminance(Bitmap hinhgoc)
        {
            Bitmap HinhMucXam = new Bitmap(hinhgoc.Width, hinhgoc.Height);
            // Duyệt qua từng hàng và từng cột của hình ảnh
            for (int x = 0; x < hinhgoc.Width; x++)
            {
                for (int y = 0; y < hinhgoc.Height; y++)
                {
                    // Lấy màu của điểm ảnh từ hình ảnh gốc tại (x, y)
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

        // Tính histogram của ảnh xám
        //định nghĩa một phương thức có tên là TinhHistogram với đầu vào là một đối tượng Bitmap có tên là HinhMucXam.
        public double[] TinhHistogram(Bitmap HinhMucXam)
        {
            // Khai báo một mảng histogram có 256 phần tử để lưu số đếm của các mức xám từ 0 đến 255.
            double[] histogram = new double[256];

            // Duyệt qua từng pixel của hình ảnh mức xám.
            for (int x = 0; x < HinhMucXam.Width; x++)
            {
                for (int y = 0; y < HinhMucXam.Height; y++)
                {
                    // Lấy màu của pixel tại vị trí (x, y) trong hình ảnh xám và lưu nó vào biến color.
                    Color color = HinhMucXam.GetPixel(x, y);

                    // Trong hình mức xám, giá trị kênh R cũng giống G hoặc B vì đó là mức xám.
                    // Lấy giá trị kênh R (độ xám) của pixel và lưu vào biến gray.
                    byte gray = color.R;

                    // Giá trị gray là giá trị của mức xám của pixel hiện tại.
                    // Tăng số đếm của phần tử thứ gray trong mảng histogram lên 1.
                    histogram[gray]++;
                }
            }

            // Trả về mảng histogram đã tính.
            return histogram;
        }


        PointPairList ChuyenDoiHistogram(double[] histogram)
        //phương thức ChuyenDoiHistogram nhận một mảng histogram làm đầu vào
        //và trả về một danh sách các điểm (PointPairList) được tạo ra từ mảng histogram đó
        {
            // PointPairList là kiểu dữ liệu của ZedGraph để lưu danh sách các điểm dùng để vẽ biểu đồ.
            PointPairList points = new PointPairList();

            // Duyệt qua mảng histogram để chuyển đổi dữ liệu thành các điểm trên biểu đồ.
            for (int i = 0; i < histogram.Length; i++)
            {
                // Trục nằm ngang (X) sẽ là giá trị i (các giá trị mức xám từ 0 đến 255).
                // Trục đứng (Y) sẽ là giá trị histogram[i] (số lượng pixels có mức xám tương ứng).
                // Mỗi điểm trong PointPairList biểu thị một giá trị mức xám và số lượng pixels có mức xám đó.
                points.Add(i, histogram[i]);
            }

            // Trả về danh sách các điểm đã được tạo từ mảng histogram.
            return points;
        }


        // Thiết lập một biểu đồ trong ZedGraph
        public GraphPane BieuDoHistogram(PointPairList histogram)
        {
            // GraphPane là đối tượng biểu đồ trong ZedGraph.
            GraphPane gp = new GraphPane();

            gp.Title.Text = @"Biểu đồ Histogram"; // Tên của biểu đồ
            gp.Rect = new Rectangle(0, 0, 600, 400); // Khung chứa biểu đồ.

            // Thiết lập trục ngang
            gp.XAxis.Title.Text = @"Giá trị mức xám của các điểm ảnh";
            gp.XAxis.Scale.Min = 0; // Nhỏ nhất là 0
            gp.XAxis.Scale.Max = 255; // Lớn nhất là 255
            gp.XAxis.Scale.MajorStep = 5; // Mỗi bước chính là 5
            gp.XAxis.Scale.MinorStep = 1; // Mỗi bước trong một bước là 1

            // Tương tự thiết lập cho trục đứng
            gp.YAxis.Title.Text = @"Số điểm ảnh có cùng mức xám";
            gp.YAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 15000; // Số này phải lớn hơn kích thước ảnh (w x h)
            gp.YAxis.Scale.MajorStep = 5;
            gp.YAxis.Scale.MinorStep = 1;

            // Dùng biểu đồ dạng bar để biểu diễn histogram
            gp.AddBar("Histogram", histogram, Color.OrangeRed);

            return gp;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void zGHistogram_Load(object sender, EventArgs e)
        {
        }
    }
}
