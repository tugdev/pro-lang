//~ cumledeki kelimelerin ilk ve son harflerini buyuten program
#include <stdio.h>
#include <ctype.h>
int k_sonu_buyut(char s[])
{
	int i=0;
	for (i = 0;s[i]!='\0'; i++)
	{	if(s[i]==' ' && isalnum(s[i+1]))  //~ kelimelerin ilk harfini buyutmak icin
		{	s[i+1]=toupper(s[i+1]);
		}
		 else if((isalnum(s[i]) && s[i+1]==' ') || (isalnum(s[i]) && s[i+1]=='\0' ))  //~ kelimelerin son harfini buyutmek icin
		{	s[i]=toupper(s[i]);
		}
		else{
			continue;}
	}
	s[0]=toupper(s[0]);
	printf("%s",s);
	return 0;
}
int main()
{
	char s[100];
    printf("Bir cumle giriniz=>");
    gets(s);
	k_sonu_buyut(s);
	//~ printf("\nCumlenin son hali: %s", s);
	return 0;
}
