clc
clear

im=imread('yazi.png');
k = strel('disk', 2, 6); 
img=imerode(im,k);
b=im-img;

subplot(1,2,1),imshow(im); title('Orjinal Hali');
subplot(1,2,2),imshow(b); title('Sýnýrlarý');