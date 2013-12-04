clc
clear
I = imread('coins.png');
bw = im2bw(I);

temiz = imfill(bw, 'holes');
imshow(temiz);

[L,T] = bwlabel(temiz);

R = regionprops(L, 'Area'); % alanlarý
a = [R.Area]
% length(a) 10
% a      2650    1854     2678    1810     2751    2509    2592    2538  1891    1863

f=a>2000
% f     1     0     1     0     1     1     1     1     0    0
 
bes_kurus=0;
on_kurus=0;
toplam=0;
for i=1:length(a)
    if f(i)==1
        toplam=toplam+10;
        on_kurus=on_kurus+1;
    else
        toplam=toplam+5;
        bes_kurus=bes_kurus+1;
    end
end
fprintf('resimdeki 5 kurus sayisi : %d \n ' , bes_kurus)
fprintf('resimdeki 10 kurus sayisi : %d \n ' ,on_kurus)
fprintf('resimdeki toplam para sayisi : %d \n ' , toplam)