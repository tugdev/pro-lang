#include <stdio.h>
struct ogrenci{
     char  *ad;
     char  *soyad;
     int   no;
};
int fonksiyon(struct ogrenci s)
{
   printf("\n*** Girilen bilgiler ***");
   printf("\nNo    : %d",s.no );
   printf("\nAdi   : %s ",s.ad);
   printf("\nKisi.soyad: %s ",s.soyad);
}
int main(){

	struct ogrenci Kisi;
	Kisi.ad= "tugba";
	Kisi.soyad = "devravut";
	Kisi.no = 10060276;
	fonksiyon(Kisi);
  return 0;
}
