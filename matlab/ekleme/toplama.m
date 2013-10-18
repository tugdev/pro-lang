clear all;
clc;
I=imread('aslan.bmp');
I2=imread('kadin.jpg');
imshow( I ); hold on;
 h = imagesc( I2 ); 
 set( h, 'AlphaData', .5 ); 
 colormap gray