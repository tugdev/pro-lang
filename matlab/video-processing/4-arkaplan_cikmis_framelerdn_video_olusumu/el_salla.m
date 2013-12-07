clc
clear
  
aviobj = avifile('el_salla','compression','None');   %avifile bos bir avi uzantýlýdosya oluþturur.(el_salla isimli video oluscak) 
aviobj.Quality = 80;
aviobj.COMPRESSION ='None';
dbnm='5/';     
d=dir([dbnm,'*png']);             % 5 isimli klasordeki frameleri(png uzantýlý olanlari al)
[x,y]=size(d); 
 for i =1:x
    yol=strcat(dbnm, d(i).name);
    a = imread(yol);
    aviobj = addframe(aviobj,a);   %addframe iþlemi oluþturduðumuz bos video dosyasýna gelen framei yükler.
 end
aviobj=close(aviobj);  %close ile avi dosyasýný kapatýldý