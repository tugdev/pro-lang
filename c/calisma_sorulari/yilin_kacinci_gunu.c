#include <stdio.h>
int yilin_gunu(int gun, int ay, int yil)
{
   int y_gun = gun;

   switch(ay-1)
   {
     case 11: y_gun += 30;
     case 10: y_gun += 31;
     case  9: y_gun += 30;
     case  8: y_gun += 31;
     case  7: y_gun += 31;
     case  6: y_gun += 30;
     case  5: y_gun += 31;
     case  4: y_gun += 30;
     case  3: y_gun += 31;
     case  2: y_gun += 28;  
     case  1: y_gun += 31;
   }

  return y_gun;
}
int main()
{	int a;
	a=yilin_gunu(20,12,1992);
	printf("yilin %d . günü",a);
	return 0;
}
