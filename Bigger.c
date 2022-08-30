#include <stdio.h>

main()
{
	int a, b;
	printf("Enter the first number:");
	scanf("%d", &a);
	printf("Enter another number:");
	scanf("%d", &b);
	if (a > b)
		printf("%d", a);
	else
		printf("%d", b);
}
