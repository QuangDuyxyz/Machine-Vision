#Công thức chính sử dụng là hàm tính khoảng cách Euclidean Distance
#Xem công thức 6.7-1 trang 445 : D(z,a) = SQRT[(zR - aR)^2 + (zG - aG)^2 + (zB - aB)^2]
#Có 2 vector :
    #a : VECTOR MÀU TRUNG BÌNH (AVERAGE COLOR)
        #chọn một vùng ảnh từ vị trí (x1, y1) đến vị trí (x2, y2)
        #a = [aR aG aB] : ba thành phần trung bình màu cho từng kênh R-G-B
        #Tại mỗi kênh R-G-B tiến hành tính TB cộng tất cả các điểm ảnh (pixel) thuộc vùng ảnh đã chọn ở trên
    #z : điểm ảnh tại vị trí (x, y) đang muốn tính xem là điểm thuộc nền (background) hay thuộc đối tượng (object)
        #z(x, y) = [R(x,y) G(x,y) B(x,y)] = [zR zG zB]
#Có giá trị D(z,a), so sánh với GT ngưỡng (threshold) D0 để xác định xem điểm z(x,y) đang xét là background hay object
    #Nếu D(z,a) <= D0 thì z(x,y) là background
        #Có thể set màu cho điểm này về màu trắng (255) hoặc đen (0) hay bất kỳ màu gì tùy chọn.
    #Nếu D(z,a) > D0 thì z(x,y) là object, giữ nguyên màu cho điểm này.

import cv2
from PIL import Image
import numpy as np


#Đọc ảnh với OpenCV
img_OpenCV = cv2.imread('D:\\Machine_Vision\\Lena_goc.jpg', cv2.IMREAD_COLOR)
#img_OpenCV = cv2.imread('bird_small_resize.jpg', cv2.IMREAD_COLOR)

#Đọc ảnh với PILLOW dùng để xử lý và tính toán thay vì dùng OpenCV
img_PIL = Image.open('D:\\Machine_Vision\\Lena_goc.jpg')
#img_PIL = Image.open('bird_small_resize.jpg')

#Tạo 1 ảnh có cùng size và mode với ảnh img_PIL dùng để chứa KQ chuyển đổi RGB sang Segmentation
SegmentationIMG = Image.new(img_PIL.mode, img_PIL.size)

#Lấy kích thước ảnh
Width = img_PIL.size[0]
Height = img_PIL.size[1]

#Khai báo GT ngưỡng (Threshold)
Threshold = 45

#Chọn vùng ảnh cho vector a
x1 = 80
y1 = 400
x2 = 150
y2 = 500

# Khai báo các biến này kiểu int để chứa và có thể đọc được giá trị cộng dồn
aR_TB = 0
aG_TB = 0
aB_TB = 0

#Mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng lặp For để đọc hết các điểm ảnh (pixel) có trong hình
#Đọc giá trị pixel có trong hình
for x in range (x1,x2+1) :
    for y in range (y1,y2+1) :

        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R, G, B = img_PIL.getpixel((x,y))
        #Cộng dồn điểm ảnh cho mỗi kênh R-G-B tương ứng
        aR_TB += R
        aG_TB += G
        aB_TB += B

#Tại mỗi kênh R-G-B tiến hành tính TB cộng tất cả các điểm ảnh (pixel) thuộc vùng ảnh đã chọn ở trên
#Tính SIZE cho vecto a : Size = |x2-x1| * |y2-y1|
Size = np.abs(x2+1-x1) * np.abs(y2+1-y1)
aR_TB /= Size
aG_TB /= Size
aB_TB /= Size

for a in range(Width) :
    for b in range(Height) :
        # Lấy giá trị điểm ảnh tại vị trí (a,b)
        zR,zG,zB = img_PIL.getpixel((a, b))
        #Tính k/c D theo Euclidean Distance (6.7-1 /445)
        #D(z,a) = SQRT[(zR - aR)^2 + (zG - aG)^2 + (zB - aB)^2]
        D = np.sqrt((zR-aR_TB)**2 + (zG-aG_TB)**2 + (zB-aB_TB)**2)
        #So sánh với GT ngưỡng (threshold) để xác định z(x,y) là background hay object
        if (D<=Threshold) :
            SegmentationIMG.putpixel((a,b),(255,255,255))
        else :
            SegmentationIMG.putpixel((a,b),(zB,zG,zR))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
Segmentation = np.array(SegmentationIMG)

#Hiển thị ảnh với OpenCV
cv2.imshow('RGB Image', img_OpenCV)
cv2.imshow('Segmentation Image', Segmentation)

#Bấm phím bất kì để đóng cửa sổ
cv2.waitKey()

#Giải phóng bộ nhớ
cv2.destroyAllWindows()




