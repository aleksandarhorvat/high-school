#include <stdio.h>
#include <math.h>

main()
{
	long int p;
	int a, i;
	printf("Enter number a: ");
	scanf("%d", &a);
	p = 1;
	for (i = 0; i <= a; i++)
	{
		if (i == 0)
		{
			p = 1;
		}
		else
		{
			p = p * 2;
		}

		printf("\n %li %d %d", i, p, a);
	}
}
