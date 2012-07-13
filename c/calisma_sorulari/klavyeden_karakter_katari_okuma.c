#include <stdio.h>
#include <ctype.h>
int k_dizi()
{
	char s[100];
	int i=0;
	gets(s);
	for(i=0;s[i]!='\0';i++)
	{	 if(isdigit(s[i])){
			putchar(s[i]);}
		else if(isalpha(s[i])){
			putchar('*');}
		//~ else if(s[i]==10) break;
		else{
			putchar('_');}
	}
}

int main()
{
		
	k_dizi();
	return 0;
}
//~ ---------------------------------iki farklı program----------------------------------------------------------------
#include <stdio.h>
#include <ctype.h>
int main()
{

	char c;
	for(;;)
	{
		c=getchar();
		if(isdigit(c)){
			putchar(c);}
		else if(isalpha(c)){
			putchar('*');}
		//~ else if(c==10) break;
		else{
			putchar('_');}
		}
		return 0;
	}

