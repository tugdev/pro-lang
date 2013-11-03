clc
clear 


im=imread('bonibon.jpg');

r=im(:,:,1);
g=im(:,:,2);
b=im(:,:,3);

%yesil renk için

bwr = abs(double(r) - 80) <= 80;
bwg = abs(double(g) - 240) <= 80;
bwb = abs(double(b) - 60) <= 80;  
bw = bwr .* bwg .* bwb;  
 
bw3 = cat(3, bw,bw,bw);   
yesil = uint8(double(im) .* bw3);
 
%****************************
%mavi renk için  

bwr = abs(double(r) - 40) <= 80;  
bwg = abs(double(g) - 90) <= 80;   
bwb = abs(double(b) - 170) <= 80;   
bw = bwr .* bwg .* bwb; 
 
bw3 = cat(3, bw,bw,bw);   
mavi = uint8(double(im) .* bw3);


%****************************
%bordo renk için

bwr = abs(double(r) - 165) <= 50;  
bwg = abs(double(g) - 30) <= 50;   
bwb = abs(double(b) - 30) <= 50;   
bw = bwr .* bwg .* bwb;  

bw3 = cat(3, bw,bw,bw);   
bordo = uint8(double(im) .* bw3);

%****************************
%sari renk için bu tamam

bwr = abs(double(r) - 240) <= 80;  
bwg = abs(double(g) - 233) <= 80;   
bwb = abs(double(b) - 5) <= 80;   
bw = bwr .* bwg .* bwb; 

bw3 = cat(3, bw,bw,bw);   
sari = uint8(double(im) .* bw3);
 
%****************************
%turuncu renk için 

bwr = abs(double(r) - 255) <= 60;  
bwg = abs(double(g) - 90) <= 60;   
bwb = abs(double(b) - 0) <= 60;   
bw = bwr .* bwg .* bwb;  

bw3 = cat(3, bw,bw,bw);   
turuncu = uint8(double(im) .* bw3);

%****************** hepsi  **************

subplot(3,2,1); imshow(im); title('Bonibon');
subplot(3,2,2); imshow(sari); title('sari bonibonlar');
subplot(3,2,3); imshow(yesil); title('yesil bonibonlar');
subplot(3,2,4); imshow(mavi); title('mavi bonibonlar');
subplot(3,2,5); imshow(turuncu); title('turuncu bonibonlar');
subplot(3,2,6); imshow(bordo); title('bordo bonibonlar');














