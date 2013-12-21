
clear all; close all; clc;

[filename1,pathname]=uigetfile('*.*','select the image'); 
image1=imread(num2str(filename1));
figure(1);
imshow(image1);	title('original image');     % orginal image for watermarking
image1=double(image1);

[row,col]=size(image1);

imagew=imread('dmg2.tif');
%figure(2);imshow(imagew)

[row,col]=size(image1);

Tr=250;
k=0.02;

[ca,ch,cv,cd] = dwt2(image1,'db1');
c1 = [ch cv cd];

[h, w] = size(ca');
[m, n] = size(c1');

imagew=dmg(imagew,image1);
[caa chh cvv cdd]=dwt2(imagew,'db1');
imagew=caa;
size(imagew);

% watermark grüntü ekle.
for i=1:h
    for j=1:w
        if ca(i,j)>Tr
            Ca(i,j)=ca(i,j)+k*imagew(i,j);   % <--------k*abs(double(c1(i,j)))*W(i,j); de olabilir
        else
            Ca(i,j)=ca(i,j);
        end
    end
end

% CH1=C1(1:h,1:w);
% CV1=C1(1:h,w+1:2*w);
% CD1=C1(1:h,2*w+1:3*w);

[marked]= double( idwt2(Ca,ch, cv, cd,'db1') );

markedmax = max(marked(:));
markscale = marked/markedmax*255;


figure(2);
colormap(gray(256));
image(marked);							
title('Watermarked image');
imwrite(marked,gray(256),'marked_image.bmp');	
figure(3);
watermark=image1-marked;			
watermark=watermark*255/max(watermark(:));

for i = 1:row                       
     for j = 1:col
        if watermark(i,j) > 70 
            watermark(i,j) = 255;
        end
        if watermark(i,j) < 70
            watermark (i,j) = 0;
        end
    end
end
colormap(gray(256));
image(watermark);						
title('watermark');
imwrite(marked,gray(256),'result_watermark.bmp');		

