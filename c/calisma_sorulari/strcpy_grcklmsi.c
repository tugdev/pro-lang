#include <stdio.h>
int strcpy_grcklmsi(char *dizi)
{
	char s[100];
	int i;
	for(i=0;dizi[i];i++)
	{
		s[i]=dizi[i];
	}
	s[i]='\0';                                 //sonlandırıcı eklenmeli                                 
	printf("%s\n",dizi);
	printf("%s\n",s);
return 0;
}
int main()
{
	strcpy_grcklmsi("tugdev");
	return 0;
}	



















