clc
close all
 
FDetect = vision.CascadeObjectDetector;
resim1 = imread('1.jpg');
%boyut ayarlan�yor
resim=imresize(resim1, [240 320]);
% y�z belirleniyor
BB = step(FDetect,resim);
figure,
subplot(2,4,1);
imshow(resim); hold on
for i = 1:size(BB,1)
rectangle('Position',BB(i,:),'LineWidth',1,'LineStyle','-','EdgeColor','r');
end
title('y�z belirlendi');
hold off;

% y�z k�rp�l�yor
yuz=imcrop(resim,BB);
subplot(2,4,2);
imshow(yuz);
title('y�z k�rp�ld�');

% a��z belirleniyor
MouthDetect = vision.CascadeObjectDetector('Mouth','MergeThreshold',130);
BBb=step(MouthDetect,yuz);
subplot(2,4,3);
imshow(yuz);
title('a��z belirleme');
hold on
for i = 1:size(BBb,1)
rectangle('Position',BBb(i,:),'LineWidth',1,'LineStyle','-','EdgeColor','r');
end
hold off;
% a��z belirleniyor
agiz=imcrop(yuz,BBb); %A�IZ
subplot(2,4,4);
imshow(agiz);
title('a��z k�rp�ld�');

% g�z belirleniyor
EyeDetect = vision.CascadeObjectDetector('EyePairBig');
BBa=step(EyeDetect,yuz);
subplot(2,4,5);
imshow(yuz);
title('g�z belirlendi');
rectangle('Position',BBa,'LineWidth',1,'LineStyle','-','EdgeColor','b');
% g�z k�rp�l�yor
goz=imcrop(yuz,BBa);
subplot(2,4,6);
imshow(goz);
title('g�z k�rp�ld�');

% burun belirleniyor
NoseDetect = vision.CascadeObjectDetector('Nose','MergeThreshold',45);
BBs=step(NoseDetect,yuz);
subplot(2,4,7);
imshow(yuz); hold on
for i = 1:size(BBs,1)
rectangle('Position',BBs(i,:),'LineWidth',1,'LineStyle','-','EdgeColor','b');
end
title('burun belirleniyor');
hold off;
% burun k�rp�l�yor
burun=imcrop(yuz,BBs);
subplot(2,4,8);
imshow(burun);
title('burun k�rp�ld�');

