
clc
clear
%1) resimde kaç adet zar var? cevap m adet
i=imread('zar.png');
level=graythresh(i);
bw=im2bw(i,level);
[L,N] = bwlabel(bw);
m=max(L(:))





neg = 1-bw;
[L2,N2] = bwlabel(neg);
%N2-1  %toplam nokta sayýsý
m2=max(L2(:))
m2=m2-1; %label 1 olarak resmin tamamýný etiketler yani nokta deðildir

subplot(1,2,1);imshow(bw); title(['toplam ',num2str(m), ' adet zar var']);
subplot(1,2,2);imshow(neg); title(['zarlarda toplam ',num2str(m2), ' adet nokta var']);