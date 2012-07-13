#include <stdio.h>
#include <string.h>
int tersle(char s[])
{
	int i=0,k; 
	char t;           
	k=strlen(s);                                
	while((k/2)-1>0)
	{
		t=s[i];
		s[i]=s[k-1];
		s[k-1]=t;
		k-=1;
		i+=1;
	}
	printf("%s",s);
	return 0;
}
int main()
{
	char s[]="tugdev";
	tersle(s);
	return 0;
}
