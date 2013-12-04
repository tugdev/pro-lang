clc
clear

satir=imread('satir.png');
yaz=rgb2gray(satir);
level=graythresh(yaz);
im=im2bw(yaz,level);

se1 = strel('disk',4);   % 4'lük diskler yardýmý ile
img = imerode(im,se1);   % aþýndýrma yaptýk

img=1-img;

[x,y]=size(img);
A=sum(img);  %her sutun toplamýný al
s=1;
kbitis=0;kbas=0;

for i=1:length(A)
    if((i+1)<=length(A))
        n=i+1;
        if(A(i)==0&&A(n)~=0)
         kbas=i;   
        elseif(A(i)~=0&&A(n)==0)
         kbitis=i;
        end
        if(kbitis>kbas)
             M=imcrop(satir,[kbas,0,kbitis-kbas,y]);
             imwrite(M,num2str(s,'kelime_%02d.png'));
             s=s+1; kbitis=0;kbas=0;
             
        end
    end
    
    
end