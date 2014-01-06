clc
clear all;

i=imread('cameraman.tif');
im=double(i);
im=uint8(255-im);
imshow(im)
