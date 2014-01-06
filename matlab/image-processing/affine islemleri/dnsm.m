A = [0.5 0 0; 0.5 2 0; 0 0 1];
tform = maketform('affine', A);

xy  =[10 20]                %tanýmlanan noktalar
uv  = tformfwd(tform, xy)   %dönüþüm sonucu oluþacak degerler bulunur.ölçekleme yapýlýyor,hedef noktalar
xyp = tforminv(tform, uv)   %bulunan noktalardan geri dönüþüm yapmak istersek

