#include <stdio.h>
#include <ctype.h>
void k_dizi()
{
	char s[100];
	int i=0;
	gets(s);
	for(i=0;s[i]!='\0';i++)
	{	 
		if(s[i]>=97 && s[i]<=122)
		{
			s[i]-=32;
			putchar(s[i]);
		}
		else{
			putchar(s[i]);}
	}
}
int main()
{	
	k_dizi();
	return 0;
}
