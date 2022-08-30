#include<stdio.h>
int addition(int a,int b);

main()
{
	int n,m,s;
	printf("Enter your numbers: ");
	scanf("%d%d",&n,&m);
	s=addition(n,m);
	printf("Sum is %d",s);
}
int addition(int a,int b)
{
	int x;
	x=a+b;
	return x;
}
