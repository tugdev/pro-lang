clear all;
clc;
I=rgb2gray(imread('aslan.bmp'));
I2=rgb2gray(imread('kadin.jpg'));
K = imadd(I2,I,'uint16');
imshow(K,[])