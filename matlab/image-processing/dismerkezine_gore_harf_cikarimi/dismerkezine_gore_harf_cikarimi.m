clc
clear
 
im=imread('text.png');
imshow(im)

CC = bwconncomp(im);  % baðlý komponentleri buldurur.
L = labelmatrix(CC);   % bwconncomp yapýsýndan etiket matrisi oluþturur

props = regionprops(CC, 'eccentricity');
id = ( [props.Eccentricity] > 0.6);

im2 = ismember(L,find(id));    %# Eccentricity>0.6   dýþmerkezi
im3 = ismember(L,find(~id));   %# Eccentricity<0.6



subplot(1,3,1); imshow(im);
subplot(1,3,2); imshow(label2rgb(im2));
subplot(1,3,3); imshow(label2rgb(im3));
