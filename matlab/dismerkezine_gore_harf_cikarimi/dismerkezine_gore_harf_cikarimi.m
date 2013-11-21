clc
clear
 
im=imread('text.png');
imshow(im)

CC = bwconncomp(im);  % ba�l� komponentleri buldurur.
L = labelmatrix(CC);   % bwconncomp yap�s�ndan etiket matrisi olu�turur

props = regionprops(CC, 'eccentricity');
id = ( [props.Eccentricity] > 0.6);

im2 = ismember(L,find(id));    %# Eccentricity>0.6   d��merkezi
im3 = ismember(L,find(~id));   %# Eccentricity<0.6



subplot(1,3,1); imshow(im);
subplot(1,3,2); imshow(label2rgb(im2));
subplot(1,3,3); imshow(label2rgb(im3));
