A = [0.5 0 0; 0.5 2 0; 0 0 1];
tform = maketform('affine', A);

xy  =[10 20]                %tan�mlanan noktalar
uv  = tformfwd(tform, xy)   %d�n���m sonucu olu�acak degerler bulunur.�l�ekleme yap�l�yor,hedef noktalar
xyp = tforminv(tform, uv)   %bulunan noktalardan geri d�n���m yapmak istersek

