clc % uygulamay� her calistird�g�mda ekran� temizle
clear % uygulamay� her calistird�g�mda degisken vb. temizle

I=imread('coins.png'); % resmi okuyaca��z 
sz = size(I) % resmin boyutunu alaca��z
% sz(1) resmin eni 
% sz(2) resmin boyu 

 fprintf('resmin eni %d\n', sz(1));
 fprintf('resmin boyu %d\n', sz(2));

 
 %  resimde piksel degeri 30 olanlar� bulal�m 
 
 toplamPikselSayisi = 0;
 piksel30 = 0;
 
 for i=1:sz(1)
        for j=1:sz(2)
            
            if I(i,j) == 30  
            % dolas�rken piksel degeri 30 olursa bu if dongusune gir
              piksel30 = piksel30 + 1;
           end
            toplamPikselSayisi = toplamPikselSayisi + 1;
          
    end
 end
fprintf('resimdeki 30 degerindeki piksel say�s� %d\n', piksel30);
fprintf('resimdeki toplam piksel sayisi %d\n', toplamPikselSayisi);