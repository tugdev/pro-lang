#include <stdio.h>
enum takimlar_renkleri{ 
	Sari_Kirmizi,
	Siyah_Beyaz,
	Bordo_Mavi,
	Sari_Lacivert,
	Kirmizi_Beyaz
}renkler;
int takim(int c)
{	
	printf("takim renk numarasini giriniz (Sari_Kirmizi=1,Siyah_Beyaz=2,Bordo_Mavi=3,Sari_Lacivert=4,Kirmizi_Beyaz=5)=> ");
	scanf("%d",&c);
	if(c==1)
		return Sari_Kirmizi;
	if(c==2)
		return Siyah_Beyaz;	
	else if(c==3)
		return Bordo_Mavi;	
	else if(c==4)
		return Sari_Lacivert;	
	else if(c==5)
		return Kirmizi_Beyaz;	
			
}
int main()
{	int c;
    renkler=takim(c);  

    if(renkler == Sari_Kirmizi )
         printf(" tuttugunuz takim galatasaray, renkleride Sari ve Kirmizi"); 
    else if(renkler == Siyah_Beyaz)
		 printf(" tuttugunuz takim besiktas, renkleride Siyah ve Beyazdir"); 
    else if(renkler == Bordo_Mavi)
		 printf(" tuttugunuz takim trabzonspor, renkleride Bordo ve Mavidir"); 
    else if(renkler == Sari_Lacivert)
		 printf(" tuttugunuz takim fenerbahce, renkleride Sari ve Laciverttir"); 
    else if(renkler == Kirmizi_Beyaz)
		 printf(" tuttugunuz takim samsunspor, renkleride kirmizi ve beyazdir"); 

  return 0;
}
