clc
clear

im=imread('saha.png');

r=im(:,:,1);
g=im(:,:,2);
b=im(:,:,3);

bwr=abs(double(r)-0) <=0;
bwg=abs(double(g)-162) <=5;
bwb=abs(double(b)-232)  <=5;

bw=bwr.*bwg.*bwb;
bw = imfill(bw,'holes');
bw=cat(3,bw,bw,bw);
top = uint8(double(im) .* bw);

sz=size(bw);

saha1=bw (1:sz(1)/2 , 1:sz(2)/2);

saha2=bw (sz(1)/2+1:sz(1) , 1:sz(2)/2);

saha3=bw (1:sz(1)/2 , sz(2)/2+1:sz(2));

saha4=bw (sz(1)/2+1:sz(1) , sz(2)/2+1:sz(2));

 if (sum (saha1(:)) > sum (saha2(:)) && sum (saha1(:)) > sum (saha3(:)) && sum (saha1(:)) > sum (saha4(:)) )  
            konum=' Top sol usttedir. '
            
    elseif (sum(saha2(:)) > sum (saha1(:)) && sum (saha2(:)) > sum (saha3(:)) && sum (saha2(:)) > sum (saha4(:)) )  
            konum=' Top sol alttadýr. '
            
    elseif (sum(saha3(:)) > sum (saha1(:)) && sum (saha3(:)) > sum (saha2(:)) && sum (saha3(:)) > sum (saha4(:)))   
            konum=' Top sag usttedir. '
            
    elseif (sum(saha4(:)) > sum (saha1(:)) && sum (saha4(:)) > sum (saha3(:)) && sum (saha4(:)) > sum (saha2(:)) )  
           konum=' Top sag alttadýr '

 end
 
subplot(1,2,1);imshow(im); title(konum);
subplot(1,2,2);imshow(top);




