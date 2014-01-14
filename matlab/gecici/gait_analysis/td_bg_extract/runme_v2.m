
dbnm='../_db/';

% dbnm_in: video framlerin bulundu�u dizin
dbnm_in=pathos(strcat(dbnm,'in/'));
% dbnm_crpHuman:k�rp�lm�s insan frameleri dizini
dbnm_crpHuman=pathos(strcat(dbnm,'out/crpbox/crpHuman/'));
%dbnm_crpMask: k�rp�lm�s  insan maskesi dizini
dbnm_crpMask=pathos(strcat(dbnm,'out/crpbox/crpMask/'));
%dbnm_rgbHuman:k�rp�lmam�s  kare i�indeki rgb insan dizini
dbnm_rgbHuman=pathos(strcat(dbnm,'out/rgbHuman/'));

DIR=dir([dbnm_in,'*.bmp']);
sz=length(DIR);  %dizinde ka� adet kare var
sz
N = 23;  % 23.kareden ba�la

% 6 framelik aral�klarla frameleri inceleyerek arkaplan resmini c�kar�r.
one=imread(strcat(dbnm_in,DIR(N).name));
next=imread(strcat(dbnm_in,DIR(N + 6).name));

%okunan iki resimdeki insalar�n farkl� konumda olmas� gerekmektedir.

arkaplan= arkaplanCikar(one,next);
%figure(1);imshow(arkaplan);
imwrite(arkaplan,'background2.jpg');

%human
I=next;
k = arkaplan - I;
k=rgb2gray(k);
k=medfilt2(k);
k = im2bw(k, graythresh(k));
    
 bwh = bwareaopen(k, 35);
 bwh3 = uint8(cat(3, bwh, bwh, bwh));
 bwh_bg = I .* bwh3;

 figure(2); imshow(bwh_bg);
 imwrite(bwh_bg,'human.jpg');
