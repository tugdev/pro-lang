#include <stdio.h>
#include <string.h>
int tersle(char s[])
{
	int i=0,k,l,a=0; 
	char t,d[6];           
	k=strlen(s); 
	l=k;
	for (i = 0; k>i; i++)  // d stringini s stringine eşitledim
	{
		d[i]=s[i];
	}
	//~ printf("%s\n",d);    kontrol satiri
	for (i = 0;k/2-1>i; i++)    // s stringini ters cevirdim   
	{
		t=s[i];
		s[i]=s[l-1];
		s[l-1]=t;
		l-=1;
	}
	//printf("%s\n",s);     kontrol satiri
	for (i = 0; k>i; i++)            //karsilastirma
	{
		if(d[i]==s[i])
			a+=1;					// sayiyi artirma
	}
	if(a==k)				//a dizi uzunluguna esitse true dondercek
		printf("true");
	else
			printf("false");
	return 0;
}
int main()
{
	char s[]="kabak";
	tersle(s);
	return 0;
}
