clc
clear

satir=imread('kelime.png');
yaz=rgb2gray(satir);
level=graythresh(yaz);
im=im2bw(yaz,level);

se1 = strel('line',1,1);   
img = imerode(im,se1);  
imshow(img)
img=1-img;

[x,y]=size(img);
A=sum(img);  %her sutun toplamýný al
s=1;
hbitis=0;hbas=0;

for i=1:length(A)
    if((i+1)<=length(A))
        n=i+1;
        if(A(i)==0&&A(n)~=0)
         hbas=i;   
        elseif(A(i)~=0&&A(n)==0)
         hbitis=i-1;
        end
        if(hbitis>hbas)
             M=imcrop(satir,[hbas,0,hbitis-hbas,y]);
             
             imwrite(M,num2str(s,'harf_%02d.png'));
             s=s+1; hbitis=0;hbas=0;
             
        end
    end
    
    
end