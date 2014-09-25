clc
close all
 
FDetect = vision.CascadeObjectDetector;
resim1 = imread('1.jpg');
%boyut ayarlanýyor
resim=imresize(resim1, [240 320]);
% yüz belirleniyor
BB = step(FDetect,resim);
figure,
subplot(2,4,1);
imshow(resim); hold on
for i = 1:size(BB,1)
rectangle('Position',BB(i,:),'LineWidth',1,'LineStyle','-','EdgeColor','r');
end
title('yüz belirlendi');
hold off;

% yüz kýrpýlýyor
yuz=imcrop(resim,BB);
subplot(2,4,2);
imshow(yuz);
title('yüz kýrpýldý');

% aðýz belirleniyor
MouthDetect = vision.CascadeObjectDetector('Mouth','MergeThreshold',130);
BBb=step(MouthDetect,yuz);
subplot(2,4,3);
imshow(yuz);
title('aðýz belirleme');
hold on
for i = 1:size(BBb,1)
rectangle('Position',BBb(i,:),'LineWidth',1,'LineStyle','-','EdgeColor','r');
end
hold off;
% aðýz belirleniyor
agiz=imcrop(yuz,BBb); %AÐIZ
subplot(2,4,4);
imshow(agiz);
title('aðýz kýrpýldý');

% göz belirleniyor
EyeDetect = vision.CascadeObjectDetector('EyePairBig');
BBa=step(EyeDetect,yuz);
subplot(2,4,5);
imshow(yuz);
title('göz belirlendi');
rectangle('Position',BBa,'LineWidth',1,'LineStyle','-','EdgeColor','b');
% göz kýrpýlýyor
goz=imcrop(yuz,BBa);
subplot(2,4,6);
imshow(goz);
title('göz kýrpýldý');

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
% burun kýrpýlýyor
burun=imcrop(yuz,BBs);
subplot(2,4,8);
imshow(burun);
title('burun kýrpýldý');

