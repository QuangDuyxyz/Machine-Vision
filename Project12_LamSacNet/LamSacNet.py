import cv2
from PIL import Image
import numpy as np

#Đọc ảnh với OpenCV
#img_OpenCV = cv2.imread('lena_color_resize.jpg', cv2.IMREAD_COLOR)
img_OpenCV = cv2.imread('D:\\Machine_Vision\\bird_small.jpg', cv2.IMREAD_COLOR)

#Đọc ảnh với PILLOW dùng để xử lý và tính toán thay vì dùng OpenCV
#img_PIL = Image.open('lena_color_resize.jpg')
img_PIL = Image.open('D:\\Machine_Vision\\bird_small.jpg')

#Tạo 1 ảnh có cùng size và mode với ảnh img_PIL dùng để chứa KQ chuyển đổi RGB sang YCrCb
SharpeningIMG = Image.new(img_PIL.mode, img_PIL.size)

#Tạo ma trận thay thế để tính toán cho PP Laplacian
#Có 4 mask :
    #Filter mask used to implement Eq.(3.6-6)
        #a :  [[0,1,0],[1,-4,1],[0,1,0]]
    #Mask used to implement an extension of this equation that includes the diagonal terms
        #b : [[1,1,1],[1,-8,1],[1,1,1,]]
    #Two other implementations of the Laplacian found frequently in practice
        #c : [[0,-1,0],[-1,4,-1],[0,-1,0]]
        #d : [[-1,-1,-1],[-1,8,-1],[-1,-1,-1]]
#Ở đây ta dùng mask c
Matrix = np.array([[0,-1,0],[-1,4,-1],[0,-1,0]])

#Lấy kích thước ảnh
Width = img_PIL.size[0]
Height = img_PIL.size[1]


#Mỗi hình là 1 ma trận 2 chiều nên dùng 2 vòng lặp For để đọc hết các điểm ảnh (pixel) có trong hình
#Đọc giá trị pixel có trong hình
#Để dễ lập trình, bỏ qua viền ngoài của ảnh
#Mask 3x3 : x=1 tới x=Width-1 ; y=1 tới y=Height-1
for x in range (1,Width-1) :
    for y in range (1,Height-1) :
        #Khai báo các biến này kiểu int để chứa và có thể đọc được giá trị cộng dồn nằm trong mặt nạ
        Rs = 0
        Gs = 0
        Bs = 0
        #Quét các điểm trong mặt nạ
        #Lưu ý : Python (a,b) : Chạy từ a tới b-1. Muốn lấy bằng b thì giá trị đó phải +1
        for i in range(x-1,x+2) :
            for j in range(y-1,y+2) :
                #Lấy thông tin màu R-G-B tại điểm ảnh có trong mặt nạ tại vị trí (i,j)
                R, G, B = img_PIL.getpixel((i,j))
                #Nhân tích chập cho tất cả điểm ảnh của mỗi kênh R-G-B
                Rs += R*Matrix[i-x+1,j-y+1]
                Gs += G*Matrix[i-x+1,j-y+1]
                Bs += B*Matrix[i-x+1,j-y+1]
        #Kết thúc quét và cộng dồn
        #Tính điểm sắc nét mỗi kênh theo CT 3.6-7
        R1,G1,B1 = img_PIL.getpixel((x,y))
        Sharp_R = R1 + Rs
        Sharp_G = G1 + Gs
        Sharp_B = B1 + Bs

        if (Sharp_R<0) :
            Sharp_R = 0
        elif (Sharp_R>255) :
            Sharp_R = 255

        if (Sharp_G < 0):
            Sharp_G = 0
        elif (Sharp_G > 255):
            Sharp_G = 255

        if (Sharp_B<0) :
            Sharp_B = 0
        elif (Sharp_B>255) :
            Sharp_B = 255

        SharpeningIMG.putpixel((x,y),(Sharp_B,Sharp_G,Sharp_R))

#Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
Sharpening = np.array(SharpeningIMG)

#Hiển thị ảnh với OpenCV
cv2.imshow('RGB Image', img_OpenCV)
cv2.imshow('Sharpening - 3x3 Image', Sharpening)

#Bấm phím bất kì để đóng cửa sổ
cv2.waitKey()

#Giải phóng bộ nhớ
cv2.destroyAllWindows()




