//~ trimleme =>arada ki fazla boşluğu yok et ve ilk harfleri buyut
#include <stdio.h>
#include <ctype.h>
void titlecase(char s[])
{
	int i,c;
	for(i=0,c=1;s[i]!='\0';i++)
	{	if(c==1 && s[i]!='\0')
		{	s[i]=toupper(s[i]);
			c=0;}
		else if(s[i]==' ' && s[i+1]!=' ')	
		{	c=1;}
	}
}		
		




void bosluk_sil(char s[])
{
	//~ char s[100];
	int i=0;
	//~ gets(s);
	for(i=0;s[i]!='\0';i++)
	{	 
		 if(isalnum(s[i])) printf("%c",s[i]);	
		 else if(s[i]==' ' && s[i+1]==' '){             
			continue; }
		 else if(s[i]==' ')
		 { 
			 printf("%c",s[i]);
			 }
	}
}
int main()
{	char s[100];
    printf("Bir cumle giriniz=>");
    gets(s);
	titlecase(s);
	bosluk_sil(s);
	//~ printf("\nCumlenin son hali: %s", s);
	return 0;
}
