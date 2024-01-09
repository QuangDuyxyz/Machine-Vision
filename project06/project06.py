import cv2                      # Sử dụng thư viện OpenCV
from PIL import Image           # Thư viện xử lý ảnh PILLOW hỗ trợ nhiều loại định dạng ảnh
import numpy as np              # Thư viện toán học, ma trận
import matplotlib.pyplot as plt  # Sửa import matplotlib

# Khai báo đường dẫn file hình
filehinh = ('C:\\Users\\Qduy\\Desktop\\Machine_Vision\\Lena_goc.jpg')

# Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

# Đọc ảnh màu bằng PILLOW để tính toán thay vì dùng OpenCV
imgPIL = Image.open(filehinh)

# Tạo 4 ảnh có cùng kích thước và mode với ảnh imgPIL để chứa kết quả chuyển đổi RGB sang CMYK
cyan = Image.new(imgPIL.mode, imgPIL.size)
magenta = Image.new(imgPIL.mode, imgPIL.size)
yellow = Image.new(imgPIL.mode, imgPIL.size)
black = Image.new(imgPIL.mode, imgPIL.size)

# Lấy kích thước của ảnh từ imgPIL
width = imgPIL.size[0]
height = imgPIL.size[1]

# Mỗi ảnh là một ma trận 2 chiều nên dùng 2 vòng lặp for để đọc các điểm ảnh
for x in range(width):
    for y in range(height):
        # Lấy giá trị điểm ảnh tại vị trí (x,y)
        R, G, B = imgPIL.getpixel((x, y))
        
        # Cyan (xanh dương) là kết hợp giữa green và blue nên red = 0
        cyan.putpixel((x, y), (0, G, B))
        
        # Magenta (tím) là sự kết hợp giữa red và blue nên green = 0
        magenta.putpixel((x, y), (R, 0, B))
        
        # Yellow (vàng) là sự kết hợp giữa red và green nên blue = 0
        yellow.putpixel((x, y), (R, G, 0))
        
        # Lấy giá trị min trong 3 giá trị RGB
        MIN = min(R, G, B)
        black.putpixel((x, y), (MIN, MIN, MIN))
#chuyển CMYK sang RGB theo quy tắc:
##Cyan (C) và Black (K) sang Red (R):
#R = 255 * (1 - C / 100) * (1 - K / 100)
##Magenta (M) và Black (K) sang Green (G):
#G = 255 * (1 - M / 100) * (1 - K / 100)
##Yellow (Y) và Black (K) sang Blue (B):
#B = 255 * (1 - Y / 100) * (1 - K / 100)
# Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
xanhduong = np.array(cyan)
tim = np.array(magenta)
vang = np.array(yellow)
den = np.array(black)

# Tạo một bố cục tùy chỉnh cho việc hiển thị
fig, axs = plt.subplots(2, 5, figsize=(20, 10))

# Hiển thị ảnh gốc ở hàng 1
img = cv2.imread(filehinh)
axs[0,0].imshow(img)
# axs[0, 0].imshow(cv2.cvtColor(img, cv2.COLOR_BGR2RGB))
axs[0, 0].set_title("Ảnh màu RGB gốc")
axs[0, 0].axis('off')

# Hiển thị các kênh màu CMYK ở hàng 2
axs[1, 0].imshow(cyan)
axs[1, 0].set_title("Kênh Cyan")
axs[1, 0].axis('off')

axs[1, 1].imshow(magenta)
axs[1, 1].set_title("Kênh Magenta")
axs[1, 1].axis('off')

axs[1, 2].imshow(yellow)
axs[1, 2].set_title("Kênh Yellow")
axs[1, 2].axis('off')

axs[1, 3].imshow(black)
axs[1, 3].set_title("Kênh K")
axs[1, 3].axis('off')

# Loại bỏ các trục trắng không cần thiết
for i in range(5):
    axs[0, i].axis('off')
    axs[1, i].axis('off')

plt.tight_layout()

# Sửa lỗi: Thêm cv2.waitKey(0) để chờ người dùng ấn phím trước khi đóng cửa sổ hình ảnh
cv2.waitKey(0)
plt.show()
