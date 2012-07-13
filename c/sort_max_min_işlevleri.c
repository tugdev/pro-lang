//sort ,max,min işlevleri//
#include <stdio.h>
#include <string.h>

void sort(int s[] , int n)
{
	
	int i,j,t,k;
	
	for (i = 0; i < n;i++)
	{
		for (j = 0; j <n; j++)
		{
			if(s[i]<s[j])
			{
				t=s[i];
				s[i]=s[j];
				s[j]=t;
			}
		}
		
	}
	for (k=0;k<n;k++){
        printf("%d",s[k]);}
	
	printf("\n min degeri  %d\n",s[0]);
	printf("\n max degeri  %d\n",s[n-1]);
	
}
int main(void)
{
   int dizi[]={8,4,5,6,9,2,4};
   sort(dizi,7);
   return 0;
   }
	
