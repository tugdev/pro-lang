#include <stdio.h>
#include <string.h>
int karakter_ara(char s[])
{	int j,i=0;
	j=strlen(s);
	while((j)>0)
	{	if(s[i]==s[i+1] && s[i+1]==s[i+2]){
			putchar(s[i]);
		}
		i+=1;
		j-=1;
	}
	return 0;
}
int main()
{	karakter_ara("banaaaanananooo");	
    return 0;
}           
    
