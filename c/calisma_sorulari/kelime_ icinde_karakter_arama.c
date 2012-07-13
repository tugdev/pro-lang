#include <stdio.h>
#include <string.h>
int karakter_ara(char s[])
{	int j,i=0;
	int k=0;
	j=strlen(s);
	while((j)>0)
	{	if(s[i]=='n' && s[i+1]=='a' && s[i+2]=='n' && s[i+3]=='o'){
			k+=1;}
		i+=1;
		j-=1;
	}
	if(k!=0){
		printf("true");}
	else{	
		printf("false");}
	return 0;
}
int main()
{	karakter_ara("banananano");	
    return 0;
}           
    
