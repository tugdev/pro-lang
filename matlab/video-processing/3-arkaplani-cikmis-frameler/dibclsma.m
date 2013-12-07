clc
clear


video= mmreader('el.avi');   %videoyu oku
%i=1;
 s=1;
 for k=1:video.NumberOfFrames   % videoda kac tane frame var => video.NumberOfFrames
     rgb = read(video, k);    % videonun k. framini getir 
     I = rgb2gray(rgb);
     background = imclose(I, strel('disk',4));
I2 = imsubtract(background,I);

BW = im2bw(I2,graythresh(I2));
BW=bwareaopen(BW,155);

%se1 = strel('disk',1);
%BW = imdilate(BW,se1);


im3=imfill(BW,'holes');
im3=uint8(im3);
	
im3(im3 == 255) = 1;
im33 = cat(3, im3, im3, im3);
im = rgb .* im33;
%figure(i);      imshow(im)
 %    i=i+1;
 
  imwrite(im,num2str(s,'im_%03d.png'));   % videonun k. framini kaydet 'frame_%03d.png' isimde 
     s=s+1;
 end
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
