#include <stdio.h>
#include <string.h>
int quick_sort(int dizi[],int pivot,int boyut)

{	int i,k=0,j,t;
    int d[boyut];
	for (i = 0; i < boyut; i++)
	{
		if(dizi[i]<pivot)  //eger pivot degerinden kucukse pivotun soluna
		{	d[k]=dizi[i];
			k+=1;}
	}
	for (i = 0; i < boyut; i++)   //eger pivot degerine esitse pivotu
	{
		if(dizi[i]==pivot) 
		{	d[k]=pivot;
			k+=1;}
	}
	for (i = 0; i < boyut; i++)   //eger pivot degerinden buyukse pivotun sagina
	{
		if(dizi[i]>pivot)
		{	d[k]=dizi[i];
			k+=1;}
	}
	for (i = 0; i < boyut;i++)       //siraliyalim burda 
	{
		for (j = 0; j <boyut; j++)
		{
			if(d[i]<d[j])
			{
				t=d[i];
				d[i]=d[j];
				d[j]=t;
			}
		}

	}
	
	
	
	
	for (i = 0; i <boyut; i++)
	{
		printf("%2d",d[i]);
	}
return 0;
}
int main()
{	int dizi[]={3,6,9,5,1};
	quick_sort(dizi,5,5);
	return 0;
}
