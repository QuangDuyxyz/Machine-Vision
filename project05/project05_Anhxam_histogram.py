from PIL import Image                #Thư viện xử lí ảnh PILLOW hỗ trợ nhiều định dạng ảnh
import matplotlib.pyplot as plt      #Thư viện vẽ biểu đồ
import numpy as np                   #Thư viện toán học, đặc biệt tính toán ma trận
import cv2                           #Thư viện xử lí ảnh OpenCV

# Đường dẫn đến tập tin hình ảnh gốc
filehinh = r'C:\Users\Qduy\Desktop\Machine_Vision\bird_small.jpg'
# Đọc ảnh dùng thư viện PIL
imgPIL = Image.open(filehinh)

# Chuyển đổi sang mức xám bằng phương pháp Luminance
def convert_to_luminance_grayscale(image):
    grayscale_image = Image.new("L", image.size)
    for x in range(image.width):
        for y in range(image.height):
            pixel = image.getpixel((x, y))
            R, G, B = pixel[0], pixel[1], pixel[2]
            gray_value = int(0.299 * R + 0.587 * G + 0.114 * B)
            grayscale_image.putpixel((x, y), gray_value)
    return grayscale_image

# Tính histogram của ảnh màu xám
def TinhHistogram(HinhXamPIL):
    # Mỗi pixel có giá trị từ 0- 255, nên phải khai báo một mảng có 256 phần tử để chứa số đếm của các pixel có cùng giá trị
    his = np.zeros(256)

    # Kích thước ảnh
    W = HinhXamPIL.size[0]
    h = HinhXamPIL.size[1]
    for x in range(W):
        for y in range(h):
            # Lấy giá trị xám tại điểm (x, y)
            gray_value = HinhXamPIL.getpixel((x, y))
            # Giá trị Gray tính ra cũng chính là phần tử thứ gray_value trong mảng his đã khai báo trước đó, sẽ tăng số đếm
            # của phần tử thứ gray_value lên 1
            his[gray_value] += 1
    return his

# Vẽ biểu đồ Histogram dùng thư viện matplotlib
def VeBieuDoHistogram(his):
    W = 5
    h = 4
    plt.figure('Biểu đồ histogram ảnh xám', figsize=((W, h)), dpi=100)
    trucX = np.arange(256)
    trucY = his
    plt.plot(trucX, trucY, color='orange')
    plt.title('Biểu đồ Histogram')
    plt.xlabel('Giá trị mức xám')
    plt.ylabel('Số đếm cùng giá trị mức xám')
    plt.show()

# Chuyển sang ảnh màu xám
HinhXamPIL = convert_to_luminance_grayscale(imgPIL)

# Tính histogram
his = TinhHistogram(HinhXamPIL)

# Chuyển ảnh PIL sang OpenCV để hiển thị bằng thư viện CV2
HinhXamCV = np.array(HinhXamPIL)
cv2.imshow('Anh muc xam', HinhXamCV)

# Hiển thị biểu đồ Histogram
VeBieuDoHistogram(his)

# Bấm phím bất kì để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ 
cv2.destroyAllWindows()
