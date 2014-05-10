function [rgbHuman,crpMask,crpHuman]=human_extraction(arkaplan, frame)

    %arkaplandan farkl� olan insan� belirler
    k = arkaplan - frame;
    an = im2bw(k, 0.5);
    Dbw = bwareaopen(an, 35);
    Db = Dbw;
    [L, n] = bwlabel(Db);   %Bu k�s�mda BWLabel hatas� vard� do�ru olan bwlabel
    
    % BoundingBox nesnesinin kordinatlar�na gore maske belirler
    STATS = regionprops(L,'BoundingBox','Area');
    if(~isempty(STATS))
       
       if(length(STATS)==1)
           box=cat(1,STATS.BoundingBox);
       elseif(length(STATS)>1)
           allArea = [STATS.Area];
           MaxArea=max(allArea);
           idx = [STATS.Area]==MaxArea;
           box=cat(1,STATS(idx).BoundingBox);       
       end
       box=[box(1)-1,box(2)-5,box(3)+3,box(4)+10];  %silueti s��d�rd���m�z bbox �l�ekleri burdan ayarlan�r
       tempImgSize = size(Db);
       box_width = box(3);
       box_height = box(4);
       left_x = box(1);
       right_x = box(1) + box_width;
       upper_y = box(2);
       bottom_y =box(2) + box_height;
       x = [left_x, left_x, right_x, right_x, left_x];
       y = [upper_y, bottom_y, bottom_y, upper_y, upper_y];  
       boxMask = poly2mask(x, y, tempImgSize(1), tempImgSize(2));       
    

      %  videolara ait frame ile  maskeyi birle�tirir sonuc(m)=kare i�ine
      %  al�nm�� insan
      im=uint8(frame);
      s=boolean(boxMask);
      r = uint8(cat(3, s,s,s));
      rgbHuman=im.*r;
      %rgbHuman; siyah resimde kare i�inde renkli insan
   
      kkare=imcrop(frame, box);
      crpMask=1-im2bw(kkare);%kare i�inde bw insan
    
      n=boolean(crpMask);
      r2 = uint8(cat(3, n,n,n));
      crpHuman=kkare.*r2;
    else
     rgbHuman=0;
     crpMask=0;
     crpHuman=0;
    end
end