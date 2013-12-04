
clc
clear

 video= mmreader('el.avi');   %videoyu oku
 s=1;
 for k=1:video.NumberOfFrames   % videoda kac tane frame var => video.NumberOfFrames
     Frame = read(video, k);    % videonun k. framini getir 
     imwrite(Frame,num2str(s,'frame_%03d.png'));   % videonun k. framini kaydet 'frame_%03d.png' isimde 
     s=s+1;
end