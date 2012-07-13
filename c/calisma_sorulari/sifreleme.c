#include <stdio.h>
#include <ctype.h>
int main()
{
	int c;
	for(;;)
	{
		c=getchar();
		if(isalpha(c)){c+=2; putchar(c); }
		else{
			c+=13; putchar(c);
		}
	}
	return 0;
}
