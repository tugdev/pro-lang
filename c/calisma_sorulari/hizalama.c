#include <stdio.h>
#include <string.h>
int satir(char c[],int sayi,int yon)
{	
	char satir[strlen(c)*3];
	int i=0,j=0,k=0;
	int m=sayi;
	int n=sayi*2;
	
	if(yon==1)
	{for (i = 0; i<strlen(c) ; i++)
		 {
			satir[i]=c[k];
			k+=1;
			j+=1;
			putchar(satir[i]);
			if(j==sayi)
			{   
				printf("\n");
				j=0;
			}
		 }
    }
    else if(yon==2)
    { 
		  while (m>0)
		  {
			putchar(' ');
			m-=1;
		  }
		  m=sayi;
		  for (i = 0; i<strlen(c) ; i++)
		  {
			satir[i]=c[k];
			k+=1;
			j+=1;
			putchar(satir[i]);
			   if(j==sayi)
			   {   
				printf("\n");
				j=0;
				while (m>0)
			  {
				putchar(' ');
				m-=1;
			  }
			  m=sayi;
			  }
		  }
      }
    else if(yon==3)
    { 
		while (n>0)
	    {
			putchar(' ');
			n-=1;
	    }
		n=sayi*2;
		for (i = 0; i<strlen(c) ; i++)
		{	
			satir[i]=c[k];
			k+=1;
			j+=1;
			putchar(satir[i]);
			if(j==sayi)
		    {   
				printf("\n");
				j=0;
				while (n>0)
			   {
				putchar(' ');
				n-=1;
			   }
			  n=sayi*2;
		   }
       }
    }
    return 0;
   }
int main()
{   // saga dayali yazmak icin yon=1,ortali=2,sola yasli=3
	satir("İstanbul'u dinliyorum, gözlerim kapali once hafiften bir ruzgar esiyor;Yavas yavas sallaniyor Yapraklar, agaclarda;Uzaklarda, cok uzaklarda,Sucularin hic durmayan cingiraklari İstanbul'u dinliyorum, gözlerim kapali. ",25,2);
	return 0;
}
