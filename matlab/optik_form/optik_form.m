clc
clear

rgb1 = imread('fark2.bmp');
rgb2 = imread('fark1.bmp');

pict1_R = rgb1(:, :, 1);
pict2_R = rgb2(:, :, 1);
pict1_G = rgb1(:, :, 2);
pict2_G = rgb2(:, :, 2);
pict1_B = rgb1(:, :, 3);
pict2_B = rgb2(:, :, 3);

sonuc_R = abs(pict1_R - pict2_R);
sonuc_G = abs(pict1_G - pict2_G);
sonuc_B = abs(pict1_B - pict2_B);

final = sonuc_R + sonuc_G + sonuc_B;
final = imfill(final,'holes');

%imshow(final)
s=1;
optik=final(32:154 ,:);

%imwrite(M,num2str(s,'optik_%02d.png'));
%optik=imread('optik_01.png');

%imshow(optik)
[L,T]=bwlabel(optik);
%T
s = regionprops(L, 'centroid');

m = [s.Centroid];
%m

k=2;
for i=1:(length(m)/2)
    
   %m(k) 
   if (40 <= m(k) && m(k)<=50)
       
       a(i)=3;
     
   elseif (50 <= m(k) && m(k)<=53)
      a(i)=4;
   
   elseif (63 <= m(k) && m(k)<=65)
       a(i)=5;
   
   elseif (28 <= m(k) && m(k)<=29)
      a(i)=2;
   
    
   elseif (15 <= m(k) && m(k)<=17)
       
   a(i)=1;
   
   elseif (90 <= m(k) && m(k)<=110)
     a(i)=8;
    
   elseif (4 <= m(k) && m(k)<=6)
    
       a(i)=0;
    
   elseif (110 <= m(k) && m(k)<=113)
      
    a(i)=9;
   
   end    
   k=k+2;
 
end

imshow(rgb2);title(['optik formdaki i�aretlenen say�lar = ',num2str(a)]);





