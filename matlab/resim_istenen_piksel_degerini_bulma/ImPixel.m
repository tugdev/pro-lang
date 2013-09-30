clc % uygulamayý her calistirdýgýmda ekraný temizle
clear % uygulamayý her calistirdýgýmda degisken vb. temizle

I=imread('coins.png'); % resmi okuyacaðýz 
sz = size(I) % resmin boyutunu alacaðýz
% sz(1) resmin eni 
% sz(2) resmin boyu 

 fprintf('resmin eni %d\n', sz(1));
 fprintf('resmin boyu %d\n', sz(2));

 
 %  resimde piksel degeri 30 olanlarý bulalým 
 
 toplamPikselSayisi = 0;
 piksel30 = 0;
 
 for i=1:sz(1)
        for j=1:sz(2)
            
            if I(i,j) == 30  
            % dolasýrken piksel degeri 30 olursa bu if dongusune gir
              piksel30 = piksel30 + 1;
           end
            toplamPikselSayisi = toplamPikselSayisi + 1;
          
    end
 end
fprintf('resimdeki 30 degerindeki piksel sayýsý %d\n', piksel30);
fprintf('resimdeki toplam piksel sayisi %d\n', toplamPikselSayisi);