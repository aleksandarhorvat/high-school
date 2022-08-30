#include <stdio.h>

main()
{
	int n, i = 1, b = 1;
	printf("Enter the limit: ");
	scanf("%d", &n);
	while (i <= n)
	{
		b *= i;
		i++;
	}

	printf("Factorial of a number %d is %d", n, b);
}
