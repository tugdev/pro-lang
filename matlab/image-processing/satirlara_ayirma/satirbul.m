clc
clear

yazi=imread('yazi.png');
img=rgb2gray(yazi);
level=graythresh(img);
im=im2bw(img,level);
im=1-im;
[x,y]=size(im);

 A=sum(im');
 s=1;
satirsonu=0;
satirbasi=0;
for i=1:length(A)
    if((i+1)<=length(A))
        n=i+1;
        if(A(i)==0&&A(n)~=0)
         satirbasi=i; %satiruzunlugu=y;   
        elseif(A(i)~=0&&A(n)==0)
         satirsonu=i;
        end
        if(satirsonu>satirbasi)
             M=imcrop(yazi,[0,satirbasi,y,satirsonu-satirbasi]);
            imwrite(M,num2str(s,'satir_%02d.png'));
             s=s+1; satirsonu=0;
             satirbasi=0;
        end
    end
    
    
end