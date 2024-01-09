#Nhận dạng đường biên (Edge Detection)
#Phương pháp Sobel
#Áp dụng cho ảnh màu RGB
'''
- Tại điểm ảnh f(x, y) chúng ta có thể trích xuất 3 giá trị R(x, y) là giá trị màu kênh Red tại vị trí (x, y), 
G(x, y) là giá trị màu kênh Green tại vị trí (x, y), và B(x, y) là giá trị màu kênh Blue tại vị trí (x, y)
- Ứng với mỗi kênh màu R-G-B, chúng ta sẽ tính được các giá trị:
    * Kênh R:
        gx(R) = dR/dx
        gy(R) = dR/dy
    * Kênh G:
        gx(G) = dG/dx
        gy(G) = dG/dy
    * Kênh B:
        gx(B) = dB/dx
        gy(B) = dB/dy
- Tính [gx(R) gy(R)], [gx(G) gy(G)] và [gx(B) gy(B)] bằng cách nhân ma trận mặt nạ 3x3 các điểm ảnh hàng xóm của điểm đang xét 
tại vị trí (x, y) với ma trận Sobel theo phương x (để tính gx) và theo phương y (để tính gy)
- CT (6.7-5) đến (6.7-7) để tính các giá trị gxx, gyy và gxy như sau :
        gxx = |gx(R)|^2 + |gx(G)|^2 + |gx(B)|^2
        gyy = |gy(R)|^2 + |gy(G)|^2 + |gy(B)|^2
        gxy = gx(R)*gy(R) + gx(G)*gy(G) + gx(B)*gy(B)
- CT 6.7-8 : tính giá trị góc theta:
        theta(x, y) = [actan(2*gxy/(gxx-gyy))] / 2
- CT 6.7-9 để tính giá trị F0(x, y) : 
        F0(x,y) = {0.5*[(gxx+gyy) + (gxx-gyy)*cos(2*theta(x,y)) + 2*gxy*sin(2*theta(x,y))]}^0.5
- SS GT F0 với một giá trị ngưỡng D0, nếu F0 <= D0 thì điểm đang xét f(x, y) thuộc background, ngược lại thì f(x, y) thuộc edge
'''

import cv2
from PIL import Image
import numpy as np

#Đọc ảnh với OpenCV
img_OpenCV = cv2.imread('D:\\Machine_Vision\\lena_goc.jpg', cv2.IMREAD_COLOR)

#Đọc ảnh với PILLOW dùng để xử lý và tính toán thay vì dùng OpenCV
img_PIL = Image.open('D:\\Machine_Vision\\lena_goc.jpg')

#Tạo 1 ảnh có cùng size và mode với ảnh img_PIL dùng để chứa KQ chuyển đổi sau khi nhận dạng đường biên theo Sobel
SobelIMG = Image.new(img_PIL.mode, img_PIL.size)

#Lấy kích thước ảnh
Width = img_PIL.size[0]
Height = img_PIL.size[1]

#======================================== Thiết đặt Ngưỡng - Threshold =========================================#
Threshold = 130
#============================================== Ma trận Sobel ==================================================#
#Theo phương x
MTSobel_x = np.array([[-1,-2,-1],[0,0,0],[1,2,1]])
#Theo phương y
MTSobel_y = np.array([[-1,0,1],[-2,0,2],[-1,0,1]])
#============================================== Tính toán với Sobel =================================================#
#Dùng 4 vòng for quét tất cả các điểm ảnh có trong hình
#Để dễ lập trình, bỏ qua viền ngoài của ảnh
#Mask 3x3 : x=1 tới x=Width-1 ; y=1 tới y=Height-1
for x in range(1,Width-1) :
    for y in range(1,Height-1) :
        gxx = gyy = gxy = gxR = gxG = gxB = gyR = gyG = gyB = 0
        for i in range(x-1,x+2) :
            for j in range(y-1,y+2) :
                gR, gG, gB = img_PIL.getpixel((i,j))

                gxR += gR*MTSobel_x[i-x+1,j-y+1]
                gyR += gR*MTSobel_y[i-x+1,j-y+1]

                gxG += gG*MTSobel_x[i-x+1,j-y+1]
                gyG += gG*MTSobel_y[i-x+1,j-y+1]

                gxB += gB*MTSobel_x[i-x+1,j-y+1]
                gyB += gB*MTSobel_y[i-x+1,j-y+1]
                
        #CT (6.7-5) đến (6.7-7) để tính các giá trị gxx, gyy và gxy 
        gxx = np.abs(gxR)**2 + np.abs(gxG)**2 + np.abs(gxB)**2
        gyy = np.abs(gyR)**2 + np.abs(gyG)**2 + np.abs(gyB)**2
        gxy = gxR*gyR + gxG*gyG + gxB*gyB

        #CT (6.7-8) : tính góc theta : dùng hàm atan2 trong python trong TH mẫu số (gxx-gyy)=0
        theta = 0.5*np.arctan2((2*gxy),(gxx-gyy))

        #CT 6.7-9 để tính giá trị F0(x, y) : 
        F0 = np.sqrt(0.5*((gxx+gyy) + (gxx-gyy)*np.cos(2*theta) + 2*gxy*np.sin(2*theta)))

        ##So sánh F0 với GT ngưỡng
        if (F0<=Threshold) :
            SobelIMG.putpixel((x,y),(0,0,0))
        else :
            SobelIMG.putpixel((x,y),(255,255,255))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
Sobel = np.array(SobelIMG)

#Hiển thị ảnh với OpenCV
cv2.imshow('RGB Image', img_OpenCV)
cv2.imshow('Edge Detection - Sobel - RGB Image', Sobel)

#Bấm phím bất kì để đóng cửa sổ
cv2.waitKey()

#Giải phóng bộ nhớ
cv2.destroyAllWindows()