#include <stdio.h>

main()
{
	int i, j, s = 0;
	int a[5][5] = {
		{ 4, 1, 2, 3, 1 },
		{ 4, 1, 2, 1, 6 },
		{ 4, 1, 1, 3, 6 },
		{ 4, 1, 2, 3, 6 },
		{ 1, 1, 2, 3, 6 }
	};
	for (i = 0; i < 5; i++)
	{
		for (j = 0; j < 5; j++)
		{
			if (i == j)
			{
				s += a[i][j];
			}
		}
	}

	printf("Sum of diagonal is: %d", s);
}
