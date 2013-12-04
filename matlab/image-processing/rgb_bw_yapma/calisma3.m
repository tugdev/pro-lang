

clc
clear

resim=Imread('1.jpg');
sz=size(resim);
 I= resim ;
 I = rgb2gray(I); % resmi griye cevirdim
  figure(1);imshow(I)
 
 for i=1:sz(1) 
     for j=1:sz(2)
         if resim(i,j) <= 128;
             I(i,j)=0; % 
             
         else
             I(i,j)=255;
         end
     end
 end                                         
                                      
 figure(2); Imshow(I)
figure(3);  Imshow(resim)
     