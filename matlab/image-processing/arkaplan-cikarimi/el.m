clc
clear

k = imread('frame_001.png');

I = rgb2gray(k);
background = imclose(I, strel('disk',4));
I2 = imsubtract(background,I);

BW = im2bw(I2,graythresh(I2));
BW=bwareaopen(BW,150);

%se1 = strel('disk',1);
%BW = imdilate(BW,se1);


im3=imfill(BW,'holes');

im3=uint8(im3);
	
im3(im3 == 255) = 1;
im33 = cat(3, im3, im3, im3);
im = k .* im33;
    
subplot(2,2,1);imshow(k);
subplot(2,2,2);imshow(I2);
subplot(2,2,3);imshow(BW);
subplot(2,2,4);imshow(im);
