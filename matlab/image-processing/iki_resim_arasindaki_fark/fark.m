clc
clear

fark1 = rgb2gray(imread('fark1.bmp'));
fark2 = rgb2gray(imread('fark2.bmp'));
D = imabsdiff(fark1,fark2);
Dbw = D>20;
imshow(Dbw);
Dbw_open = bwareaopen(Dbw,30);
imshow(Dbw_open);
se1 = strel('square',3);
Dbw_dilate = imdilate(Dbw_open,se1);
imshow(Dbw_dilate);
[L,T] = bwlabel(Dbw_dilate);
s = regionprops(L,'all');
c = [s.Centroid];


subplot(1, 2, 1), imshow('fark1.bmp');
hold on;
x = c(1:2:end);
y = c(2:2:end);
plot(x,y,'yo','MarkerSize',20,'LineWidth',4);

subplot(1, 2, 2), imshow('fark2.bmp');
hold on;
x = c(1:2:end);
y = c(2:2:end);
plot(x,y,'yo','MarkerSize',20,'LineWidth',4);
