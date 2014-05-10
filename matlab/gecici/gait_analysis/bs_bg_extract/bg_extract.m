dbnm='../_db/';

% dbnm_in: video framlerin bulunduðu dizin
dbnm_in=pathos(strcat(dbnm,'in/'));
% dbnm_crpHuman:kýrpýlmýs insan frameleri dizini
dbnm_crpHuman=pathos(strcat(dbnm,'out/crpbox/crpHuman/'));
%dbnm_crpMask: kýrpýlmýs  insan maskesi dizini
dbnm_crpMask=pathos(strcat(dbnm,'out/crpbox/crpMask/'));
%dbnm_rgbHuman:kýrpýlmamýs  kare içindeki rgb insan dizini
dbnm_rgbHuman=pathos(strcat(dbnm,'out/rgbHuman/'));

DIR=dir([dbnm_in,'*.bmp']);
sz=length(DIR);  %dizinde kaç adet kare var

N = 23;  % 23.kareden baþla

% 6 framelik aralýklarla frameleri inceleyerek arkaplan resmini cýkarýr.
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
        subplot(222);imshow(rgbHuman); title( 'Kare içinde rgb insan');
        subplot(223);imshow(crpMask);title('crop edilmiþ bw insan');  
        subplot(224);imshow(crpHuman);title('crop edilmiþ rgb insan');
    end
end

        

