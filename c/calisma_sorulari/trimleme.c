//~ trimleme =>arada ki fazla boşluğu yok et
#include <stdio.h>
#include <ctype.h>
void k_dizi()
{
	char s[100];
	int i=0;
	gets(s);
	for(i=0;s[i]!='\0';i++)
	{	 
		 if(isalnum(s[i])) putchar(s[i]);	
		 else if(s[i]==32 && s[i+1]==32){     //~ 32 ==' ' demek 32 yerine boslukta yazilabilir        
			continue; }
		 else if(s[i]==32)
		 { 
			 printf("%c",s[i]);
			 }
	}
}
int main()
{	
	k_dizi();
	return 0;
}
