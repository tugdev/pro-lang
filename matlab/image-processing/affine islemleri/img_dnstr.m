clc
clear all
A=[3 0 0; 0.5 2 0; 5 7 1];    
B=[1 0 0; 0 1 0; 2 3 1];

T1 = maketform('affine',A);  %(0.5 , 2) oranýnda ölçekle 
T2 = maketform('affine',B);


I = imread('cameraman.tif');
transformedI = imtransform(I,T1);

figure;
subplot(1,2,1);imshow(I);
subplot(1,2,2);imshow(transformedI);
