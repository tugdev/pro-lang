#include <stdio.h>
#include <ctype.h>

enum BOOLEAN{ FALSE, TRUE };  /* 0, 1 */

int kucuk_harf(char n){ if(islower(n)) return TRUE;  }  
int main()
{
    enum BOOLEAN sonuc;
    char x;

    printf("Bir harf girin: ");
    scanf("%c",&x);

    sonuc = kucuk_harf(x);   

    if( sonuc == TRUE )
         puts("Girilen harf kucuk "); 
    else
         puts("Girilen harf buyuk");

  return 0;
}
