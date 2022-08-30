#include <stdio.h>

main()
{
	int n, i, s;
	printf("Enter number n: ");
	scanf("%d", &n);
	for (i = 1, s = 0; i <= n; i++)
	{
		s = s + i;
	}

	printf("Sum of numbers up to the entered number n is %d", s);
}
