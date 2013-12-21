clear all; 
file_name='lena512.bmp';  % kapak nesnemizi okuyalým
cover_object=imread(file_name);
file_name='baboon.bmp';  %mesaj resmimizi okuyalým
message=imread(file_name);

% 256 gri-scale görüntü degerlerini yaymak için dönüþüm yapýlýyor
message=double(message);   
message=round(message./256);
message=uint8(message);

% gömmek için kullanacaðýmýz kapak nesnesinin boyutlarýný ayarlýyoruz
Mc=size(cover_object,1);	
Nc=size(cover_object,2);	

% mesaj nesnesinin boyutunu ayarlýyoruz
Mm=size(message,1);	        
Nm=size(message,2);	        

y = uint8(wgn(Mm,Nm,1));

% watermark oluþturmak için nesne boyutunu kapsayacak þekilce çýkýþ
% nesnesi oluþturulur
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

noisy = imnoise(watermarked_image,'gaussian'); % watermark resmine gürültü ekleyelim (Gauss gürültü)

imwrite(watermarked_image,'lsb_watermarked.bmp','bmp'); 
imwrite(noisy,'lsb_watermarked_noise.bmp','bmp');

%watermark görüntümüzü oluþturduk þimdi çözümleyelim.görüntünün arkasýndaki
%filiganý bulalým

file_name='lsb_watermarked.bmp'; %watermark görüntüyü oku
watermarked_image=imread(file_name);

% watermark görüntünün boyutlarýný belirle
Mw=size(watermarked_image,1);	
Nw=size(watermarked_image,2);	

% watermarký kurtarmak için watermark görüntüde lsb kullanýlýr
for ii = 1:Mw
    for jj = 1:Nw
        watermark(ii,jj)=bitget(watermarked_image(ii,jj),1);
    end
end

watermark=256*double(watermark);

subplot(2,2,1);imshow(cover_object,[])
title('orjinal Görüntü')
subplot(2,2,2);imshow(watermarked_image,[]) 
title('Watermark Görüntü')
subplot(2,2,3);imshow(noisy,[])  
title('Watermark ve Gürültülü Görüntü')
subplot(2,2,4);imshow(watermark,[])
title('Recovered Watermark')

