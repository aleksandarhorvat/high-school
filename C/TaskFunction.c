#include <stdio.h>

int fun(int n)
{
	int s = 0, i;
	for (i = 0; i <= n; i++)
	{
		s = s + (i *i);
	}
	return s;
}

main()
{
	int n;
	printf("How many numbers do you want to enter: ");
	scanf("%d", &n);
	printf("The sum is: %d", fun(n));
}
