using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project11_LamMuotMau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Load và hiển thị hình gốc cô gái Lena
            //Ở đây, ta dùng ảnh 300x300 để có đủ không gian cho 5 ảnh : ảnh gốc và Masks : 3x3 + 5x5 + 7x7 + 9x9
            Bitmap Original = new Bitmap(@"D:\Machine_Vision\Lena_goc.jpg");
            picBoxHinhGoc.Image = Original;

            //Hiển thị Mask 3x3
            Bitmap Smooth_3x3 = SmIMG3x3(Original);
            picBox3x3.Image = Smooth_3x3;

            //Hiển thị Mask 5x5
            Bitmap Smooth_5x5 = SmIMG5x5(Original);
            picBox5x5.Image = Smooth_5x5;

            //Hiển thị Mask 7x7
            Bitmap Smooth_7x7 = SmIMG7x7(Original);
            picBox7x7.Image = Smooth_7x7;

            //Hiển thị Mask 9x9
            Bitmap Smooth_9x9 = SmIMG9x9(Original);
            picBox9x9.Image = Smooth_9x9;

        }


        public Bitmap SmIMG3x3(Bitmap Original)
        {
            //Tạo sẵn 1 hình Bitmap để chứa ảnh được làm mượt
            Bitmap Smooth_3x3 = new Bitmap(Original.Width, Original.Height);

            //Quét các điểm ảnh có trong hình gốc RGB
            //Để dễ lập trình, ta bỏ qua viền ngoài của ảnh
            //Với Mask 3x3 : chỉ tính từ x=1 tới x=width-1 ; y=1 tới y=height-1
            //(lặp qua từng điểm ảnh của Bitmap gốc, trừ điểm ảnh ở biên,
            //vì thuật toán làm mịn sử dụng mặt nạ 3x3 (lưới nhỏ gồm 3x3 điểm ảnh)
            //và không thể áp dụng cho điểm ảnh ở rìa vì chúng không có đủ 9
            //điểm ảnh xung quanh).
            for (int x = 1; x < Original.Width - 1; x++)
                for (int y = 1; y < Original.Height - 1; y++)
                {
                    //Các biến này chứa các giá trị cộng dồn của điểm ảnh nằm trong mặt nạ
                    //Khai báo các biến sau kiểu int để có thể đọc được giá trị cộng dồn của các pixel
                    int Rs = 0, Gs = 0, Bs = 0;

                    //Quét các điểm trong mặt nạ
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            //Lấy thông tin màu R-G-B tại điểm ảnh có trong mặt nạ tại vị trí (i,j)
                            Color color = Original.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            //Cộng dồn tất cả điểm ảnh đó cho mỗi kênh R-G-B tương ứng
                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    //Kết thúc quét và cộng dồn
                    //Sau đó, tính trung bình cộng cho mỗi kênh theo công thức 6.6-1
                    //Chính xác hơn là công thức 6.6-2 cho từng kênh màu cụ thể
                    byte K = 3 * 3;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);
                    //Giá trị trung bình này sau đó được sử dụng để đặt màu cho điểm ảnh
                    //tương ứng trong Bitmap Smooth_3x3, 
                    //hiệu quả làm mịn hình ảnh. Điều này được thực hiện bằng cách
                    //lấy giá trị trung bình kiểu nguyên và chuyển nó trở lại thành
                    //giá trị byte có thể được sử dụng cho thành phần màu.
                    //Set điểm ảnh đã làm mượt (mờ) vào ảnh Bitmap
                    Smooth_3x3.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            return Smooth_3x3;
        }



        public Bitmap SmIMG5x5(Bitmap Original)
        {
            //Tạo sẵn 1 hình Bitmap để chứa ảnh được làm mượt
            Bitmap Smooth_5x5 = new Bitmap(Original.Width, Original.Height);

            //Quét các điểm ảnh có trong hình gốc RGB
            //Để dễ lập trình, ta bỏ qua viền ngoài của ảnh
            //Với Mask 5x5 : chỉ tính từ x=2 tới x=width-2 ; y=2 tới y=height-2
            for (int x = 2; x < Original.Width - 2; x++)
                for (int y = 2; y < Original.Height - 2; y++)
                {
                    //Các biến này chứa các giá trị cộng dồn của điểm ảnh nằm trong mặt nạ
                    //Khai báo các biến sau kiểu int để có thể đọc được giá trị cộng dồn của các pixel
                    int Rs = 0, Gs = 0, Bs = 0;

                    //Quét các điểm trong mặt nạ
                    for (int i = x - 2; i <= x + 2; i++)
                        for (int j = y - 2; j <= y + 2; j++)
                        {
                            //Lấy thông tin màu R-G-B tại điểm ảnh có trong mặt nạ tại vị trí (i,j)
                            Color color = Original.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            //Cộng dồn tất cả điểm ảnh đó cho mỗi kênh R-G-B tương ứng
                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    //Kết thúc quét và cộng dồn
                    //Sau đó, tính trung bình cộng cho mỗi kênh theo công thức 6.6-1
                    //Chính xác hơn là công thức 6.6-2 cho từng kênh màu cụ thể
                    byte K = 5 * 5;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //Set điểm ản đã làm mượt (mờ) vào ảnh Bitmap
                    Smooth_5x5.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            return Smooth_5x5;
        }



        public Bitmap SmIMG7x7(Bitmap Original)
        {
            //Tạo sẵn 1 hình Bitmap để chứa ảnh được làm mượt
            Bitmap Smooth_7x7 = new Bitmap(Original.Width, Original.Height);

            //Quét các điểm ảnh có trong hình gốc RGB
            //Để dễ lập trình, ta bỏ qua viền ngoài của ảnh
            //Với Mask 7x7 : chỉ tính từ x=3 tới x=width-3 ; y=3 tới y=height-3
            for (int x = 3; x < Original.Width - 3; x++)
                for (int y = 3; y < Original.Height - 3; y++)
                {
                    //Các biến này chứa các giá trị cộng dồn của điểm ảnh nằm trong mặt nạ
                    //Khai báo các biến sau kiểu int để có thể đọc được giá trị cộng dồn của các pixel
                    int Rs = 0, Gs = 0, Bs = 0;

                    //Quét các điểm trong mặt nạ
                    for (int i = x - 3; i <= x + 3; i++)
                        for (int j = y - 3; j <= y + 3; j++)
                        {
                            //Lấy thông tin màu R-G-B tại điểm ảnh có trong mặt nạ tại vị trí (i,j)
                            Color color = Original.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            //Cộng dồn tất cả điểm ảnh đó cho mỗi kênh R-G-B tương ứng
                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    //Kết thúc quét và cộng dồn
                    //Sau đó, tính trung bình cộng cho mỗi kênh theo công thức 6.6-1
                    //Chính xác hơn là công thức 6.6-2 cho từng kênh màu cụ thể
                    byte K = 7 * 7;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //Set điểm ản đã làm mượt (mờ) vào ảnh Bitmap
                    Smooth_7x7.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            return Smooth_7x7;
        }



        public Bitmap SmIMG9x9(Bitmap Original)
        {
            //Tạo sẵn 1 hình Bitmap để chứa ảnh được làm mượt
            Bitmap Smooth_9x9 = new Bitmap(Original.Width, Original.Height);

            //Quét các điểm ảnh có trong hình gốc RGB
            //Để dễ lập trình, ta bỏ qua viền ngoài của ảnh
            //Với Mask 9x9 : chỉ tính từ x=4 tới x=width-4 ; y=4 tới y=height-4
            for (int x = 4; x < Original.Width - 4; x++)
                for (int y = 4; y < Original.Height - 4; y++)
                {
                    //Các biến này chứa các giá trị cộng dồn của điểm ảnh nằm trong mặt nạ
                    //Khai báo các biến sau kiểu int để có thể đọc được giá trị cộng dồn của các pixel
                    int Rs = 0, Gs = 0, Bs = 0;

                    //Quét các điểm trong mặt nạ
                    for (int i = x - 4; i <= x + 4; i++)
                        for (int j = y - 4; j <= y + 4; j++)
                        {
                            //Lấy thông tin màu R-G-B tại điểm ảnh có trong mặt nạ tại vị trí (i,j)
                            Color color = Original.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            //Cộng dồn tất cả điểm ảnh đó cho mỗi kênh R-G-B tương ứng
                            Rs += R;
                            Gs += G;
                            Bs += B;
                        }
                    //Kết thúc quét và cộng dồn
                    //Sau đó, tính trung bình cộng cho mỗi kênh theo công thức 6.6-1
                    //Chính xác hơn là công thức 6.6-2 cho từng kênh màu cụ thể
                    byte K = 9 * 9;
                    Rs = (int)(Rs / K);
                    Gs = (int)(Gs / K);
                    Bs = (int)(Bs / K);

                    //Set điểm ản đã làm mượt (mờ) vào ảnh Bitmap
                    Smooth_9x9.SetPixel(x, y, Color.FromArgb(Rs, Gs, Bs));
                }
            return Smooth_9x9;
        }
    }
}
