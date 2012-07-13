#include <stdio.h>
int denklem(int x1, int y1,int x2, int y2)
{	

	 struct point {
     int a;
     int b;
     };
	
struct point p1, p2;
int fark1,fark2,n;                                          // y=mx+n doğrunun denklemi
     p1.a=x1;
     p1.b=y1;
     p2.a=x2;
     p2.b=y2;
     fark1=p2.a-p1.a;
     fark2=p2.b-p1.b;
     n=(fark1*p1.b)-(fark2*p1.a);
	printf("denklemimiz  %d y= %d x + %d dir.\n",fark1,fark2,n);
return 0;
}
int main()
{ 	
	denklem(1,5,5,12);
return 0;
}
