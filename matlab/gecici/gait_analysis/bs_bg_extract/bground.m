function bg = bground(I, J)
% Input
%   I: onceki kare
%   J: sonraki kare

% a) iki resim farkindan hareketli bolgeyi (bwh) cikart
k = uint8(abs(double(I) - double(J)));
bw = im2bw(k, graythresh(k)); %0.39);
bwh = bwareaopen(bw, 30);

% b) hareketten dolayi farklanani onceki kareden (I) al
bwh3 = uint8(cat(3, bwh, bwh, bwh));
bwh_bg = I .* bwh3;

% c) hareketsiz bolgeyi belirle
bwbg = 1 - bwh;

bwbg3 = uint8(cat(3, bwbg, bwbg, bwbg));
bw_bg = J .* bwbg3;

% d) arkaplan modeli cikartilir
bg = bwh_bg + bw_bg;

end