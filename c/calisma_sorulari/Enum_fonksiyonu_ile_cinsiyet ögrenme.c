//~ Enum fonksiyonu ile cinsiyet öğrenme.program sunu amaclamakta cinsiyet bilgisi istendiginde kisi "b" veya byük harfle "B" yazabilir
//~ yada "k" yazabilir "e" veya "E" yazmak ister.hepsinin bayan veya erkegi ifade etmesi.
#include <stdio.h>
enum cinsiyet{ kadin, erkek };  /* 0, 1 */
int cins(char c)
{	printf("cinsiyetinizi bas harfini giriniz=>"); 
	scanf("%c",&c);
	if(c=='k' || c=='K' || c=='b' || c=='B')
		return kadin;
	else if(c=='e' || c=='E')
		return erkek;
 }		
int main()
{	char c;
    enum cinsiyet kisi;
    kisi=cins(c);  

    if( kisi == kadin )
         printf("bayan"); 
    else
         printf("erkek"); 

  return 0;
}
