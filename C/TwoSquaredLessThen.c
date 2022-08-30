#include <stdio.h>
#include <math.h>

main()
{
	int a, n, i = 1;
	printf("Enter your limit: ");
	scanf("%d", &a);
	do {
		n = pow(2, i);
		if (n < a)
		{
			printf("\n2 on %d is less than %d", i, a);
		}
		i++;
	}
	while (n < a);
}
