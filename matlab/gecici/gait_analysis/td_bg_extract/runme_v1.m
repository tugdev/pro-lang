readerobj = mmreader('video.avi');%video oku

%okunan iki resimdeki insalar�n farkl� konumda olmas� gerekmektedir.
ilkframe=read(readerobj,1);
sonframe=read(readerobj,15);%tahmini aral�k

arkaplan= arkaplanCikar(ilkframe,sonframe);
figure(1);imshow(arkaplan);
imwrite(arkaplan,'background.jpg');
