#include <stdio.h>

int fak(int sayi)
{
	int faktryl=1;
	if (sayi==1 || sayi==0)
	{
		return 1;
	}
	else{
			
		while (sayi>0)
		{
			faktryl=faktryl*(sayi);
			sayi -=1;
		}
		return faktryl;
	}
}
int main()
{
	int faktoriyel;
	faktoriyel=fak(5);
	printf("faktoriyeli=>%d",faktoriyel);
	return 0;
}
