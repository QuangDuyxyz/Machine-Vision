import cv2
from PIL import Image
import numpy as np
import math

#Đọc ảnh với OpenCV
img_OpenCV = cv2.imread('D:\\Machine_Vision\\Lena_goc.jpg', cv2.IMREAD_COLOR)

#Đọc ảnh với PILLOW dùng để xử lý và tính toán thay vì dùng OpenCV
img_PIL = Image.open('D:\\Machine_Vision\\Lena_goc.jpg')

#Tạo 1 ảnh có cùng size và mode với ảnh img_PIL dùng để chứa KQ chuyển đổi RGB sang YCrCb
Y_IMG = Image.new(img_PIL.mode, img_PIL.size)
Cr_IMG = Image.new(img_PIL.mode, img_PIL.size)
Cb_IMG = Image.new(img_PIL.mode, img_PIL.size)
YCrCb_IMG = Image.new(img_PIL.mode, img_PIL.size)

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
        Y = (16 + (65.738 * R) / 256 + (129.057 * G) / 256 + (25.064 * B) / 256)
        Cb = (128 + (112.439 * R) / 256 - (94.154 * G) / 256 - (18.285 * B) / 256)
        Cr = (128 - (37.945 * R) / 256 - (74.494 * G) / 256 + (112.439 * B) / 256)

        #Hiển thị các kênh giá trị Y-Cr-Cb
        Y_IMG.putpixel((x,y),(np.uint8(Y),np.uint8(Y),np.uint8(Y)))
        Cr_IMG.putpixel((x,y),(np.uint8(Cr),np.uint8(Cr),np.uint8(Cr)))
        Cb_IMG.putpixel((x,y),(np.uint8(Cb),np.uint8(Cb),np.uint8(Cb)))

        #Hiển thị hình Y-Cr-Cb tổng hợp
        YCrCb_IMG.putpixel((x,y),(np.uint8(Cb),np.uint8(Cr),np.uint8(Y)))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
YIMG = np.array(Y_IMG)
CrIMG = np.array(Cr_IMG)
CbIMG = np.array(Cb_IMG)
YCrCbIMG = np.array(YCrCb_IMG)

#Hiển thị ảnh với OpenCV
cv2.imshow('RGB Image', img_OpenCV)
cv2.imshow('Y Image', YIMG)
cv2.imshow('Cr Image', CrIMG)
cv2.imshow('Cb Image', CbIMG)
cv2.imshow('YCrCb Image', YCrCbIMG)

#Bấm phím bất kì để đóng cửa sổ
cv2.waitKey()

#Giải phóng bộ nhớ
cv2.destroyAllWindows()