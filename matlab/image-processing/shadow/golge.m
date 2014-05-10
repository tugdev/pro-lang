clc
clear all;
frame=imread('tugdev2.jpg');
bw=imread('tugdev.jpg');
% max alanli olan insan'dir
[L ,n]= bwlabel(bw);
s = regionprops(L,'BoundingBox','Area');

if(~isempty(s))
       
       if(length(s)==1)
           box=cat(1,s.BoundingBox);
       elseif(length(s)>1)
           allArea = [s.Area];
           MaxArea=max(allArea);
           idx = [s.Area]==MaxArea;
           box=cat(1,s(idx).BoundingBox);       
       end
       
       box=[box(1)-1,box(2)-5,box(3)+3,box(4)+10];  %silueti sýðdýrdýðýmýz bbox ölçekleri burdan ayarlanýr
       tempImgSize = size(bw);
       box_width = box(3);
       box_height = box(4);
       left_x = box(1);
       right_x = box(1) + box_width;
       upper_y = box(2);
       bottom_y =box(2) + box_height;
       x = [left_x, left_x, right_x, right_x, left_x];
       y = [upper_y, bottom_y, bottom_y, upper_y, upper_y];  
       boxMask = poly2mask(x, y, tempImgSize(1), tempImgSize(2));       
    

      %  videolara ait frame ile  maskeyi birleþtirir sonuc(m)=kare içine
      %  alýnmýþ insan
      im=uint8(frame);
      s=boolean(boxMask);
      r = uint8(cat(3, s,s,s));
      rgbHuman=im.*r;
     % figure(1);imshow(rgbHuman);
      %rgbHuman; siyah resimde kare içinde renkli insan
   
      kkare=imcrop(frame, box);
     % figure(2);imshow(kkare)
      k=rgb2gray(kkare);
      l=graythresh(k);
               
      crpMask= 1-im2bw(k,l);%kare içinde bw insan
      % figure(3);imshow(crpMask);
      
      n=boolean(crpMask);
      r2 = uint8(cat(3, n,n,n));
      crpHuman=kkare.*r2;
     % figure(4);imshow(crpHuman);
    else
     rgbHuman=0;
     crpMask=0;
     crpHuman=0;
end
    subplot(231);imshow(frame);title( 'Frame');
    subplot(232);imshow(bw);title( 'bw');
    subplot(233);imshow(rgbHuman); title( 'Kare içinde rgb insan');
   subplot(234);imshow(kkare);title('crop edilmiþ rgb insan');
    subplot(235);imshow(crpMask);title('crop edilmiþ bw insan');  
    subplot(236);imshow(crpHuman);title('crop edilmiþ rgb insan');
