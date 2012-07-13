#include <stdio.h>
void k_dizi()
{
	char s[100];
	int i=0;
	gets(s);
	for(i=0;s[i]!='\0';i++)
	{	 
		 // if(s[i]==10 || s[i]==9 || s[i]==' ')
		  if(s[i]==10 || s[i]==9 || s[i]==32)   //~enter,tab ve boşluk tuşu
	      {
			  putchar('*');
		  }
		  else{
			  putchar(s[i]);
		  }
	}	  
} 
int main()
{
	
	k_dizi();
	return 0;
}
