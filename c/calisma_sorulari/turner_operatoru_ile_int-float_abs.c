#include <stdio.h>
int int_abs(int x)
{
	int i;
	i=(x>=0) ? x : (-1)*x;
	return i;
}
int float_abs(float x)
{    
    float i;
    i=(x>=0) ? x : (-1.0)*x;
    printf("%.2f",i);
}
int main()
{
	printf("%d \n",int_abs(-5));
	printf("%d",float_abs(-5.123));
	return 0;
}
