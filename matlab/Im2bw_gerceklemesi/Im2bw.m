
clc
clear

resim=Imread('cameraman.tif');
sz=size(resim);
 I= resim 
 for i=1:sz(1) 
     for j=1:sz(2)
         if resim(i,j) <= 128;
             I(i,j)=0; % 
             
         else
             I(i,j)=255;
         end
     end
 end %  
 
 figure(1); Imshow(I)
figure(2);  Imshow(resim)
 
 