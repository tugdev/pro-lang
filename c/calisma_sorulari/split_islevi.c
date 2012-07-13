#include <stdio.h>
#include <string.h>

int split(char dizi[],char ch)
{
	char d[strlen(dizi)];
	int i,k=0;
	
	for (i = 0; i < strlen(dizi); i++)
	{		if(dizi[i]!=ch)
			{
				d[k]=dizi[i];
				k+=1;
		    }
			
	}
	for (i = 0; i < k; i++)
	{
		printf("%c",d[i]);
	}
		
	
return 0;
}
int main()
{
	split ("a-b-c", '-');
	return 0;
}	
