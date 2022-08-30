#include <stdio.h>

main()

{
	int i, n, S = 0;
	printf("Enter n:");
	scanf("%d", &n);

	for (i = 0; i < n; i++)

	{
		if (i % 2 == 0)
			S = S + i;
	}

	printf("Sum is %d", S);
}
