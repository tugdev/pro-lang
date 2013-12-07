clc
clear
  
aviobj = avifile('el_salla','compression','None');   %avifile bos bir avi uzant�l�dosya olu�turur.(el_salla isimli video oluscak) 
aviobj.Quality = 80;
aviobj.COMPRESSION ='None';
dbnm='5/';     
d=dir([dbnm,'*png']);             % 5 isimli klasordeki frameleri(png uzant�l� olanlari al)
[x,y]=size(d); 
 for i =1:x
    yol=strcat(dbnm, d(i).name);
    a = imread(yol);
    aviobj = addframe(aviobj,a);   %addframe i�lemi olu�turdu�umuz bos video dosyas�na gelen framei y�kler.
 end
aviobj=close(aviobj);  %close ile avi dosyas�n� kapat�ld�