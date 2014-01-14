function aplan=arkaplanCikar(ilkframe,sonframe)
    a=ilkframe;
    b=sonframe;
    
    % iki resim farkýndan son resimdeki  insan Db= son resme ait bw insan
    k=a-b;
    an=im2bw(k,0.39);
    Dbw = bwareaopen(an,30);
    se1 = strel('square',4);
    Db = imdilate(Dbw,se1);

    %ilk renkli resim ile bw son resmin çarpýmý sonuc(m)=son resimde insan
    %maskesi ardýnda arkaplan
    im=uint8(a);
    s=boolean(Db);
    r = uint8(cat(3, s,s,s));
    m=im.*r;

    %bw son resmin tersini al
    Dt=1-Db;
    
    % tersini renkli son resim ile çarp
    %sonuc(m2)=renkli bahce siyah adam
    im2=uint8(b);
    s2=boolean(Dt);
    r4 = uint8(cat(3, s2,s2,s2));
    m2=im2.*r4;

    % resim=arkaplan
    resim=m+m2;
    aplan=resim;
   
end
