//~ cumledeki kelimelerin ilk harflerini basan program
#include <stdio.h>
#include <ctype.h>
int k_sonu_buyut(char s[])
{
	int i=0;
	putchar(toupper(s[0]));
	for (i = 0;s[i]!='\0'; i++)
	{	if(s[i]==' ' && isalnum(s[i+1])) 
		{	putchar(toupper(s[i+1]));
		}
		else{
			continue;}
	}
	return 0;
}
int main()
{
	char s[]="turkiye buyuk millet meclisi";
	k_sonu_buyut(s);
	return 0;
}
