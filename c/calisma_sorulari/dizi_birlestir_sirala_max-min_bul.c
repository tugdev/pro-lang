#include <stdio.h>
//iki diziyi birlestir,sırala,max ve min degerini bul
void birlestir(int d1[], int d2[], int b1, int b2) {
	int dizi[b1+b2];
	int i = 0,t=0,j=0,a;

	for (i=0; i < b1; i++) {
			dizi[i] = d1[i];
	}
	for (t=0,i; t< b2;t++, i++) {
	
			dizi[i] = d2[t];
	}
	for (i=0; i < b1 + b2; i++) {   // dizinin birlesmis hali
		printf("%5d", dizi[i]);
	}
	for (i = 0; i < b1+b2;i++)   //siralamaya basladik
	{
		for (j = 0; j <b1+b2; j++)
		{
			if(dizi[i]<dizi[j])
			{
				a=dizi[i];
				dizi[i]=dizi[j];
				dizi[j]=a;
			}
		}

	}
	printf("\n");
	for (i=0; i < b1 + b2; i++) {  //~ dizinin birlesmis-siralanmis hali
		printf("%5d", dizi[i]);
	}
	printf("\n min degeri  %d\n",dizi[0]);
	printf("\n max degeri  %d\n",dizi[(b1+b2)-1]);
}
int main(void) {
	int d1[] = {1, 3, 18};
	int d2[] = {2, 5, 7, 11, 13};
	birlestir(d1, d2, 3, 5);

	return 0;
}
