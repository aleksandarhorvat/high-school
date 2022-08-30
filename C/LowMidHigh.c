#include <stdio.h>

main()
{
	int a, b, c, min, mid, max;
	printf("Enter 1. number: ");
	scanf("%d", &a);
	printf("Enter 2. number: ");
	scanf("%d", &b);
	printf("Enter 3. number: ");
	scanf("%d", &c);
	if (a < b)
	{
		min = a;
		mid = b;
	}
	else
	{
		min = b;
		mid = a;
	}

	if (mid > c)
	{
		max = mid;
		if (min > c)
		{
			mid = min;
			min = c;
		}
		else
		{
			mid = c;
		}
	}
	else
		max = c;

	printf("Lowest: %d\n", min);
	printf("Middle: %d\n", mid);
	printf("Highest: %d", max);
}
