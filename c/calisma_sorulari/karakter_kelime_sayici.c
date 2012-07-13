#include <stdio.h>
int k_dizi()
{
	char s[100];
	int i=0,k=0,b=0;
	gets(s);
	for(i=0;s[i]!='\0';i++)
	{	 k+=1;
		 if(s[i]==32 && s[i+1]==32){                //~      gelen bi sonraki indiste boşluk ise artırma
			continue; }
		 else if(s[i]==32)
		 { 
			 b+=1;	
			 }
	}
	printf("\nkarakter sayisi=> %d",k);
	printf("\nkelime sayisi =>%d",b+1);
}

int main()
{
		
	k_dizi();
	return 0;
}
