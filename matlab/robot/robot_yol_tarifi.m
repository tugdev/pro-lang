clc
clear
%resim=imread('yol.png');
%im = imrotate(resim,90,'bicubic');  resmi bu �ekilde d�nd�r�p farkl� sonu�lar bulmay� deniyebilirsiniz.
im=imread('yol.png');
im2 = rgb2gray (im);
level=graythresh(im2);
im2=im2bw(im2,level);
img = 1-im2;
sz=size(img);

sol=img(1:sz(1),1:sz(2)/2);
sag=img(1:sz(1),sz(2)/2+1:sz(2));

if(sum(sol(:)) < sum(sag(:)))
    komut=' saga y�nel ' ;
elseif(sum(sol(:)) > sum(sag(:)))
    komut=' sola y�nel ' ;    
    
end

imshow(im);title(komut);
