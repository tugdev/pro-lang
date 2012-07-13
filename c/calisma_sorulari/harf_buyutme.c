//~ cumledeki kelimelerin ilk ve son harflerini kuculten, digerlerini buyuten program
#include <stdio.h>
#include <ctype.h>
int k_sonu_buyut(char s[])
{
	int i=0;
	for (i = 0; s[i]!='\0'; i++)
	{
		s[i]=toupper(s[i]);
	}
	for (i = 0;s[i]!='\0'; i++)
	{	if(s[i]==' ' && isalnum(s[i+1]))  //~ kelimelerin ilk harfini kucultmek icin
		{	s[i+1]=tolower(s[i+1]);
		}
		 else if((isalnum(s[i]) && s[i+1]==' ') || (isalnum(s[i]) && s[i+1]=='\0' ))  //~ kelimelerin son harfini kucultmek icin
		{	s[i]=tolower(s[i]);
		}
		else{
			continue;}
	}
	s[0]=tolower(s[0]);
	printf("%s",s);
	return 0;
}
int main()
{
	char s[100];
    printf("Bir cumle giriniz=>");
    gets(s);
	k_sonu_buyut(s);
	return 0;
}
