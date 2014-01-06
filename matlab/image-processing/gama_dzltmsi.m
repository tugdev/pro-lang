i=imread('cameraman.tif');
m=double(i);
k=m.^(2);   %gamma bozulmasý
k=uint8(k);
figure(1);imshow(k);

k=double(k);
t=k.^1/2;    %gamma düzeltmesi
t=uint8(t);
figure(2);imshow(t);