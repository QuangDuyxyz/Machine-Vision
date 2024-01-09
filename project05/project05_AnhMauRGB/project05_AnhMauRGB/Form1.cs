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

namespace project05_AnhMauRGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Load hình .jpg từ file
            Bitmap HinhGoc = new Bitmap(@"C:\Users\Qduy\Desktop\Machine_Vision\bird_small.jpg");
            //Cho hiển thị trên pictureBox
            picBoxAnhMauRGB.Image = HinhGoc;

            //BÂY GIỜ GỌI CÁC HÀM ĐÃ VIẾT ĐỂ VẼ BIỂU ĐỒ HISTOGRAM

            //Tính histogram
            double[,] histogram = TinhHistogram(HinhGoc);

            // Chuyển đổi kiểu dữ liệu.
            List<PointPairList> points = ChuyenDoiHistogram(histogram);

            // Vẽ biểu đồ histogram và cho hiển thị.
            zGHistogram.GraphPane = BieuDoHistogram(points);
            zGHistogram.Refresh();
        }
        // Tính histogram của ảnh màu RGB
        public double[,] TinhHistogram(Bitmap bmp) //tính histogram của hình ảnh được cung cấp thông qua đối số bmp
        {
            // Chúng ta dùng mảng 2 chiều để chứa thông tin histogram cho các kênh màu R, G và B.
            // 3: là số kênh màu cần lưu (R, G, B)
            // 256: là số vị trí tương ứng với giá trị màu từ 0 đến 255
            double[,] histogram = new double[3, 256]; //khởi tạo một mảng hai chiều kiểu double có tên là histogram,
                                                      //với 3 hàng và 256 cột

            // Duyệt qua từng pixel của hình ảnh (kích thước là bmp.Width x bmp.Height).
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    // Lấy màu của pixel tại vị trí (x, y) trong hình ảnh.
                    Color color = bmp.GetPixel(x, y);

                    // Lấy giá trị kênh màu R, G và B của pixel.
                    byte R = color.R;
                    byte G = color.G;
                    byte B = color.B;

                    // Tăng số đếm của các kênh màu R, G và B tương ứng lên 1 trong histogram.
                    histogram[0, R]++; // histogram của kênh màu R.
                    histogram[1, G]++; // histogram của kênh màu G.
                    histogram[2, B]++; // histogram của kênh màu B.
                }
            }

            // Trả về mảng 2 chiều chứa thông tin histogram của R, G và B.
            return histogram;
        }


        List<PointPairList> ChuyenDoiHistogram(double[,] histogram) //Đối số này là một mảng hai chiều kiểu double
                                                                    //có nhiệm vụ làm đầu vào cho phương thức.
        {
            //Dùng một mảng không cần khai báo trước số lượng phần tử để chứa các chuyển đổi.
            List<PointPairList> points = new List<PointPairList>();
            PointPairList redPoints = new PointPairList(); // Chuyển đổi histogram kênh R.
            PointPairList greenPoints = new PointPairList(); // Chuyển đổi histogram kênh G.
            PointPairList bluePoints = new PointPairList(); // Chuyển đổi histogram kênh B.


            for (int i = 0; i < 256; i++)
            {
                //i tương ứng trục nằm ngang. từ 0-255
                //histogram[i] tương ứng trục đứng , là số pixels cùng mức xám
                redPoints.Add(i, histogram[0, i]);   //Chuyển đổi cho kênh R
                greenPoints.Add(i, histogram[1, i]);   //Chuyển đổi cho kênh G
                bluePoints.Add(i, histogram[2, i]);   //Chuyển đổi cho kênh B
            }
            //Sau khi kết thúc vòng lặp for thì thông tin histogram của các kênh R G B đã được chuyển đổi thành công
            //Add các kênh vào mảng Points để trả về cho hàm.
            points.Add(redPoints);
            points.Add(greenPoints);
            points.Add(bluePoints);

            return points;
        }

        //Thiết lập một biểu đồ trong ZedGraph
        public GraphPane BieuDoHistogram(List<PointPairList> histogram) //định nghĩa một phương thức có tên là BieuDoHistogram, có kiểu trả về là GraphPane
                                                                        //và đầu vào là một danh sách (List) các đối tượng kiểu PointPairList
                                                                        //được đặt tên là histogram.
        {
            //GraphPane là đối tượng biểu đồ trong ZedGraph.
            GraphPane gp = new GraphPane();

            gp.Title.Text = @"Biểu đồ Histogram"; //Tên của biểu đồ
            gp.Rect = new Rectangle(0, 0, 600, 400); // Khung chứa biểu đồ.

            //Thiết lập trục ngang
            gp.XAxis.Title.Text = @"Giá trị màu của các điểm ảnh";
            gp.XAxis.Scale.Min = 0; // Nhỏ nhất là 0
            gp.XAxis.Scale.Max = 255; // lớn nhất là 255
            gp.XAxis.Scale.MajorStep = 5; // Mỗi bước chính là 5
            gp.XAxis.Scale.MinorStep = 1; // Mỗi bước trong một bước là 1

            //Tương tự thiết lập cho trục đứng
            gp.YAxis.Title.Text = @"Số điểm ảnh có cùng giá trị màu";
            gp.YAxis.Scale.Min = 0;
            gp.YAxis.Scale.Max = 15000; //số này phải lớn hơn kích thước ảnh(w x h)
            gp.YAxis.Scale.MajorStep = 5;
            gp.YAxis.Scale.MinorStep = 1;

            //Dùng biểu đồ dạng bar để biểu diễn histogram
            gp.AddBar("Histogram's Red", histogram[0], Color.Red);
            gp.AddBar("Histogram's Green", histogram[1], Color.Green);
            gp.AddBar("Histogram's Blue", histogram[2], Color.Blue);

            return gp;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
