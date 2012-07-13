#include <stdio.h>
#include <ctype.h>
int k_sonu_buyut(char s[])
{
	int i=0;
	for (i = 0;s[i]!='\0'; i++)
	{	if((isalnum(s[i]) && s[i+1]==' ') || (isalnum(s[i]) && s[i+1]=='\0' ))
		{	putchar(toupper(s[i]));
		}
		else{
			putchar(s[i]);
			}
	}
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
