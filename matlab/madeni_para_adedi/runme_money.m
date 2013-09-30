clc
clear

I = imread('coins.png');
bw = im2bw(I); % resmi siyah beyaz yapiyoruz.

point = imfill(bw, 'holes'); 
% imfill ile paralarin icinde bulunan gurultuleri yok ediyoruz.
% imfill paralarin icindeki siyah noktalari yok etmek icin kullanilir.

imshow(point); % resmin imfill uygulanmis hali

[label, coins] = bwlabel(point); % beyaz noktalari etiketliyoruz.

fprintf('resimde %d adet para var.\n', coins)

