import cv2
from PIL import Image
import numpy as np
import math

#Đọc ảnh với OpenCV
img_OpenCV = cv2.imread('C:\\Users\\Qduy\\Desktop\\Machine_Vision\\Lena_goc.jpg', cv2.IMREAD_COLOR)

#Đọc ảnh với PILLOW dùng để xử lý và tính toán thay vì dùng OpenCV
img_PIL = Image.open('C:\\Users\\Qduy\\Desktop\\Machine_Vision\\Lena_goc.jpg')

#Tạo 1 ảnh có cùng size và mode với ảnh img_PIL dùng để chứa KQ chuyển đổi RGB sang XYZ
X_IMG = Image.new(img_PIL.mode, img_PIL.size)
Y_IMG = Image.new(img_PIL.mode, img_PIL.size)
Z_IMG = Image.new(img_PIL.mode, img_PIL.size)
XYZ_IMG = Image.new(img_PIL.mode, img_PIL.size)

#Lấy kích thước ảnh
Width = img_PIL.size[0]
Height = img_PIL.size[1]

#Mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng lặp For để đọc hết các điểm ảnh (pixel) có trong hình
#Đọc giá trị pixel có trong hình
for x in range (Width) :
    for y in range (Height) :
        #Lấy giá trị điểm ảnh tại vị trí (x,y)
        R, G, B = img_PIL.getpixel((x,y))

        #Tính X-Y-Z
        X = (0.4124564 * R + 0.3575761 * G + 0.1804375 * B)
        Y = (0.2126729 * R + 0.7151522 * G + 0.0721750 * B)
        Z = (0.0193339 * R + 0.1191920 * G + 0.9503041 * B)

        #Hiển thị các kênh giá trị X-Y-Z
        X_IMG.putpixel((x,y),(np.uint8(X),np.uint8(X),np.uint8(X)))
        Y_IMG.putpixel((x,y),(np.uint8(Y),np.uint8(Y),np.uint8(Y)))
        Z_IMG.putpixel((x,y),(np.uint8(Z),np.uint8(Z),np.uint8(Z)))

        #Hiển thị hình XYZ tổng hợp
        XYZ_IMG.putpixel((x,y),(np.uint8(Z),np.uint8(Y),np.uint8(X)))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
XIMG = np.array(X_IMG)
YIMG = np.array(Y_IMG)
ZIMG = np.array(Z_IMG)
XYZIMG = np.array(XYZ_IMG)

#Hiển thị ảnh với OpenCV
cv2.imshow('RGB Image', img_OpenCV)
cv2.imshow('X Image', XIMG)
cv2.imshow('Y Image', YIMG)
cv2.imshow('Z Image', ZIMG)
cv2.imshow('XYZ Image', XYZIMG)

#Bấm phím bất kì để đóng cửa sổ
cv2.waitKey()

#Giải phóng bộ nhớ
cv2.destroyAllWindows()