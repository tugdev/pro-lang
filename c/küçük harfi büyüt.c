#include <stdio.h>
#include <ctype.h>
int main() {
char c;
for (;  ; )
{
	c=getchar();
	if (islower(c))
	{ 
		c=toupper(c);
	}
	else if (isupper(c))
	{
		c=tolower(c);
	}
	putchar(c);
	}
	
	return 0;
}
