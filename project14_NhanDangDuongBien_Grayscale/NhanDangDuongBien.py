#Nhận dạng đường biên (Edge Detection)
#Phương pháp Sobel
#Áp dụng cho ảnh mức xám GrayScale
"""
- Đầu tiên : RGB đổi sang GrayScale theo 1 trong 3 PP (Average,Lightness,Luminance)
- Giả sử xét điểm ảnh f(x, y) để biết pixel này là thuộc background (nền) hay edge (biên)
- Tính Gradient của f(x, y) theo công thức 10.2-9 trang 706
        gradient(f) = [gx gy]
        Trong đó:
            + gx = đạo hàm riêng bậc một của f theo x
            + gy = đạo hàm riêng bậc một của f theo y
- Tính Magnitude (length), hay còn gọi là biên độ, của vector gradient(f) theo công thức 10.2-20
        M(x, y) = |gx| + |gy|
- Để biết điểm f(x, y) đang xét thuộc background hay edge thì SS GT M(x,y) với một GT ngưỡng (threshold) D0
        + Nếu M <= D0 thì f(x, y) là thuộc background
        + Ngược lại thì f(x, y) là thuộc edge
- PP Sobel : Công thức 10.2-18 và 10.2-19 ở trang 709
        gx = (z7 + 2*z8 + z9) - (z1 + 2*z2 + z3)
        gy = (z3 + 2*z6 + z9) - (z1 + 2*z4 + z7)
    Trong đó :
        | z1 z2 z3 | = |f(x-1, y-1) f(x, y-1) f(x+1, y-1)|
        | z4 z5 z6 | = |f(x-1, y) f(x, y) f(x+1, y)|
        | z7 z8 z9 | = |f(x-1, y+1) f(x, y+1) f(x+1, y+1)|
    Ma trận Sobel theo phương x:
        | -1 -2 -1 |
        |  0  0  0 |
        |  1  2  1 |
    Ma trận Sobel theo phương y:
        | -1  0  1 |
        | -2  0  2 |
        | -1  0  1 |
- Giả sử xét 3x3 : Khi tính gx, gy thì Sobel lấy vùng ảnh 3x3 với tâm vùng ảnh là điểm f(x, y) đang xét,
nhân tích chập với các ma trận Sobel theo phương x (để tính gx) và ma trận Sobel theo phương y (để tính gy)
"""


import cv2
from PIL import Image
import numpy as np

#Đọc ảnh với OpenCV
img_OpenCV = cv2.imread('D:\\Machine_Vision\\lena_goc.jpg', cv2.IMREAD_COLOR)
#img_OpenCV = cv2.imread('bird_small_resize.jpg', cv2.IMREAD_COLOR)

#Đọc ảnh với PILLOW dùng để xử lý và tính toán thay vì dùng OpenCV
img_PIL = Image.open('D:\\Machine_Vision\\lena_goc.jpg')
#img_PIL = Image.open('bird_small_resize.jpg')

#Tạo 1 ảnh có cùng size và mode với ảnh img_PIL dùng để chứa KQ chuyển đổi RGB sang GrayScale
LuminanceIMG = Image.new(img_PIL.mode, img_PIL.size)
#Tạo 1 ảnh có cùng size và mode với ảnh img_PIL dùng để chứa KQ chuyển đổi sau khi nhận dạng đường biên theo Sobel
SobelIMG = Image.new(img_PIL.mode, img_PIL.size)

#Lấy kích thước ảnh
Width = img_PIL.size[0]
Height = img_PIL.size[1]

#========================================= RGB to GrayScale - Luminance ========================================#
#Mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng lặp For để đọc hết các điểm ảnh (pixel) có trong hình
#Đọc giá trị pixel có trong hình
for x in range (Width) :
    for y in range (Height) :
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R, G, B = img_PIL.getpixel((x,y))
        #RGB -> GrayScale
        Gray_Luminance = np.uint8(0.2126*R+0.7152*G+0.0722*B)
        #Gán giá trị Gray cho ảnh mức xám
        LuminanceIMG.putpixel((x,y),(Gray_Luminance, Gray_Luminance, Gray_Luminance))

#======================================== Thiết đặt Ngưỡng - Threshold =========================================#
Threshold = 130
#============================================== Ma trận Sobel ==================================================#
#Theo phương x
MTSobel_x = np.array([[-1,-2,-1],[0,0,0],[1,2,1]])
#Theo phương y
MTSobel_y = np.array([[-1,0,1],[-2,0,2],[-1,0,1]])
#============================================== Tính toán với Sobel =================================================#
#Nhân tích chập
#Để dễ lập trình, bỏ qua viền ngoài của ảnh
#Mask 3x3 : x=1 tới x=Width-1 ; y=1 tới y=Height-1
for x in range(1,Width-1) :
    for y in range(1,Height-1) :
        gx = 0
        gy = 0
        for i in range(x-1,x+2) :
            for j in range(y-1,y+2) :
                gR, gG, gB = LuminanceIMG.getpixel((i,j))
                gx += gR*MTSobel_x[i-x+1,j-y+1]
                gy += gR*MTSobel_y[i-x+1,j-y+1]
        #Tính Magnitude (biên độ) của vector gradient(f) theo công thức 10.2-20
        M = np.abs(gx) + np.abs(gy)
        #So sánh M với GT ngưỡng
        if (M<=Threshold) :
            SobelIMG.putpixel((x,y),(0,0,0))
        else :
            SobelIMG.putpixel((x,y),(255,255,255))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
Sobel = np.array(SobelIMG)
GrayScale = np.array(LuminanceIMG)
#Hiển thị ảnh với OpenCV
# cv2.imshow('RGB Image', img_OpenCV)
# cv2.imshow('Luminance Image', GrayScale)
cv2.imshow('Edge Detection - Sobel - Luminance Image', Sobel)

#Bấm phím bất kì để đóng cửa sổ
cv2.waitKey()

#Giải phóng bộ nhớ
cv2.destroyAllWindows()