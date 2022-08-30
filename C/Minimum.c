#include <stdio.h>

int fun(int a, int b)
{
	if (a < b)
		return a;
	else
		return b;
}

main()
{
	int x, y, c, z;
	printf("Enter 4 values: ");
	scanf("%d%d%d%d", &x, &y, &c, &z);
	printf("The smallest number is: %d", fun(fun(x, y), fun(c, z)));
}
