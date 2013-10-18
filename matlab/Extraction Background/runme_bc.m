% arkaplan ��kar�m i�lemi
rgb1 = imread('kapi.bmp');
rgb2 = imread('kapi_biri.bmp');

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
[str stn]=size(final);
for i=1:str
    for j=1:stn
        if final(i,j)==255
            final(i,j)=1;
        
        end
    end
end
img(:,:,1)=rgb2(:,:,1).*final;
img(:,:,2)=rgb2(:,:,2).*final;
img(:,:,3)=rgb2(:,:,3).*final;

subplot(1, 3, 1), imshow(rgb2);
subplot(1, 3, 2), imshow(rgb1);
subplot(1, 3, 3), imshow(img);
