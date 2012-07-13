#include <stdio.h>
#include <string.h>

int join(char dizi[],char ch)
{
	char d[100];
	int i,k=0;
	
	for (i = 0; i < strlen(dizi); i++)
	{		k+=1;
		d[k]=dizi[i];
		k+=1;
		d[k]=ch;
			
	}
	for (i = 0; i < k; i++)
	{
		printf("%c",d[i]);
	}
		
	
return 0;
}
int main()
{
	join("deneme", '-');
	return 0;
}	
