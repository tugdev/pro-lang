arkaplan=imread('bg_model.png');
frame=imread('tugdev2.jpg');
k = arkaplan - frame;
k=rgb2gray(k);
l=graythresh(k);
an = im2bw(k,l);
Dbw = bwareaopen(an, 35);
imshow(Dbw)