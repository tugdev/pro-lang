readerobj = mmreader('video.avi');%video oku

%okunan iki resimdeki insalarýn farklý konumda olmasý gerekmektedir.
ilkframe=read(readerobj,1);
sonframe=read(readerobj,15);%tahmini aralýk

arkaplan= arkaplanCikar(ilkframe,sonframe);
figure(1);imshow(arkaplan);
imwrite(arkaplan,'background.jpg');
