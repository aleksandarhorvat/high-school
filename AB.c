#include <stdio.h>

main()

{
	int a, b, i, S = 0;
	printf("Enter the lower limit of A: ");
	scanf("%d", &a);
	printf("Enter the upper limit of B: ");
	scanf("%d", &b);
	for (i = a + 1; i < b; i++)
	{
		if (i % 2 == 1)
			S = S + i;
	}

	printf("The sum of the odd numbers in between %d and %d is: %d", a, b, S);
}
