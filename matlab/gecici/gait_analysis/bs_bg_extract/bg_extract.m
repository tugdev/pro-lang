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

N = 23;  % 23.kareden ba�la

% 6 framelik aral�klarla frameleri inceleyerek arkaplan resmini c�kar�r.
one=imread(strcat(dbnm_in,DIR(N).name));
next=imread(strcat(dbnm_in,DIR(N + 6).name));
brd = bground(one,next);
imwrite(brd,'brd.jpg');

% for fd=N:sz
for fd=N:sz-24  % 23.kareden sz-24. kareye kadar bak.
    img = imread(strcat(dbnm_in, DIR(fd).name));
    [rgbHuman, crpMask, crpHuman] = human_extraction(brd,img);
    if(~isempty(rgbHuman)&&~isempty( crpMask)&& ~isempty(crpHuman))
       rhname=num2str(fd,strcat(dbnm_rgbHuman,'frame_%05d.bmp'));
       imwrite(rgbHuman,rhname);
    
       cmname=num2str(fd,strcat(dbnm_crpMask,'frame_%05d.bmp'));
       imwrite(crpMask,cmname);
    
       chname=num2str(fd,strcat(dbnm_crpHuman,'frame_%05d.bmp'));
       imwrite(crpHuman,chname);  
    
        figure(1);
        subplot(221);imshow(img);title( 'Frame');
        subplot(222);imshow(rgbHuman); title( 'Kare i�inde rgb insan');
        subplot(223);imshow(crpMask);title('crop edilmi� bw insan');  
        subplot(224);imshow(crpHuman);title('crop edilmi� rgb insan');
    end
end

        

