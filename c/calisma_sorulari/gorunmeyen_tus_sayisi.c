#include <stdio.h>
#include <ctype.h>
int k_dizi()
{
	char s[100];
	int i=0,k=0;
	gets(s);
	for(i=0;s[i]!='\0';i++)
	{	 
		if(s[i]>=0 && s[i]<=32)
		{
			k+=1;
		}
    }
    printf("görünmeyen tus sayisi=>%d",k);
}
int main()
{
		
	k_dizi();
	return 0;
}
