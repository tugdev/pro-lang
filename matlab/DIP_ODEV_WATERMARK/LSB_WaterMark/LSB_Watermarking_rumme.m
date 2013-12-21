clear all; 
file_name='lena512.bmp';  % kapak nesnemizi okuyal�m
cover_object=imread(file_name);
file_name='baboon.bmp';  %mesaj resmimizi okuyal�m
message=imread(file_name);

% 256 gri-scale g�r�nt� degerlerini yaymak i�in d�n���m yap�l�yor
message=double(message);   
message=round(message./256);
message=uint8(message);

% g�mmek i�in kullanaca��m�z kapak nesnesinin boyutlar�n� ayarl�yoruz
Mc=size(cover_object,1);	
Nc=size(cover_object,2);	

% mesaj nesnesinin boyutunu ayarl�yoruz
Mm=size(message,1);	        
Nm=size(message,2);	        

y = uint8(wgn(Mm,Nm,1));

% watermark olu�turmak i�in nesne boyutunu kapsayacak �ekilce ��k��
% nesnesi olu�turulur
for ii = 1:Mc
    for jj = 1:Nc
        watermark(ii,jj)=message(mod(ii,Mm)+1,mod(jj,Nm)+1);
    end
end
watermarked_image=cover_object;
for ii = 1:Mc
    for jj = 1:Nc
        watermarked_image(ii,jj)=bitset(watermarked_image(ii,jj),1,watermark(ii,jj));
    end
end

noisy = imnoise(watermarked_image,'gaussian'); % watermark resmine g�r�lt� ekleyelim (Gauss g�r�lt�)

imwrite(watermarked_image,'lsb_watermarked.bmp','bmp'); 
imwrite(noisy,'lsb_watermarked_noise.bmp','bmp');

%watermark g�r�nt�m�z� olu�turduk �imdi ��z�mleyelim.g�r�nt�n�n arkas�ndaki
%filigan� bulal�m

file_name='lsb_watermarked.bmp'; %watermark g�r�nt�y� oku
watermarked_image=imread(file_name);

% watermark g�r�nt�n�n boyutlar�n� belirle
Mw=size(watermarked_image,1);	
Nw=size(watermarked_image,2);	

% watermark� kurtarmak i�in watermark g�r�nt�de lsb kullan�l�r
for ii = 1:Mw
    for jj = 1:Nw
        watermark(ii,jj)=bitget(watermarked_image(ii,jj),1);
    end
end

watermark=256*double(watermark);

subplot(2,2,1);imshow(cover_object,[])
title('orjinal G�r�nt�')
subplot(2,2,2);imshow(watermarked_image,[]) 
title('Watermark G�r�nt�')
subplot(2,2,3);imshow(noisy,[])  
title('Watermark ve G�r�lt�l� G�r�nt�')
subplot(2,2,4);imshow(watermark,[])
title('Recovered Watermark')

