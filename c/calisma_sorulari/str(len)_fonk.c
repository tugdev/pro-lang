#include <stdio.h>

int say(char s[])
{
	int i,k=0;
	for(i=0;s[i]!='\0';i++)
	{
		k+=1;
	}
		return k;
}
int main()
{
	char s[100];
	int t;
	printf("kelime giriniz=>");
	gets(s);
	t=say(s);
	printf("%d",t);
	return 0;
}		
