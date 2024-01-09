from PIL import Image
import matplotlib.pyplot as plt
import numpy as np
import cv2

# Đường dẫn đến tập tin hình ảnh gốc
filehinh = r'C:\Users\Qduy\Desktop\Machine_Vision\bird_small.jpg'

# Đọc ảnh dùng thư viện OpenCV
bird_image = cv2.imread(filehinh)

# Lấy kích thước của ảnh
height, width, _ = bird_image.shape

# Tính histogram cho từng kênh màu
def TinhHistogramRGB(image):
    # Tạo mảng chứa histogram cho kênh màu đỏ (R), xanh lá cây (G), và xanh dương (B).
    his_red = np.zeros(256)
    his_green = np.zeros(256)
    his_blue = np.zeros(256)

    # Duyệt qua từng dòng (y) và cột (x) của hình ảnh.
    for y in range(height):
        for x in range(width):
            # Lấy giá trị màu của pixel tại vị trí (x, y).
            pixel = image[y, x]
            
            # Trích xuất giá trị kênh màu đỏ (R), xanh lá cây (G), và xanh dương (B) từ pixel.
            r, g, b = pixel[2], pixel[1], pixel[0]
            
            # Tăng giá trị tương ứng trong histogram cho các kênh màu R, G, và B lên 1.
            his_red[r] += 1
            his_green[g] += 1
            his_blue[b] += 1

    # Trả về các mảng histogram cho các kênh màu R, G, và B.
    return his_red, his_green, his_blue


# Vẽ biểu đồ Histogram dùng thư viện matplotlib cho từng kênh màu
def VeBieuDoHistogramRGB(his_red, his_green, his_blue):
    trucX = np.arange(256)

    plt.figure('Biểu đồ histogram ảnh RGB', figsize=(15, 4), dpi=100)
    plt.subplot(131)
    plt.plot(trucX, his_red, color='red')
    plt.title('Biểu đồ Histogram Kênh Đỏ')
    plt.xlabel('Giá trị màu đỏ')
    plt.ylabel('Số đếm')

    plt.subplot(132)
    plt.plot(trucX, his_green, color='green')
    plt.title('Biểu đồ Histogram Kênh Xanh Lá')
    plt.xlabel('Giá trị màu xanh lá')
    plt.ylabel('Số đếm')

    plt.subplot(133)
    plt.plot(trucX, his_blue, color='blue')
    plt.title('Biểu đồ Histogram Kênh Xanh Dương')
    plt.xlabel('Giá trị màu xanh dương')
    plt.ylabel('Số đếm')

    plt.tight_layout()
    plt.show()

# Tính histogram cho các kênh màu
his_red, his_green, his_blue = TinhHistogramRGB(bird_image)

# Hiển thị biểu đồ Histogram cho từng kênh màu
VeBieuDoHistogramRGB(his_red, his_green, his_blue)

# Hiển thị ảnh gốc
cv2.imshow('Ảnh màu gốc', bird_image)

# Bấm phím bất kì để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ
cv2.destroyAllWindows()
