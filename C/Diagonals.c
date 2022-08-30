#include <stdio.h>

main()
{
	int i, j, m = 0, n = 0;
	int a[5][5] = {
		{ 1, 2, 3, 4, 5 },
		{ 2, 3, 1, 5, 4 },
		{ 1, 3, 2, 4, 5 },
		{ 3, 1, 4, 5, 2 },
		{ 2, 5, 1, 3, 4 }
	};
	for (i = 0; i < 5; i++)
	{
		for (j = 0; j < 5; j++)
		{
			if (i == j)
			{
				m += a[i][j];
			}

			if (i == 5 - j - 1)
			{
				n += a[i][j];
			}
		}
	}

	if (m > n)
	{
		printf("The sum of the elements on the main diagonal is greater than the sum of the elements on the minor diagonal");
	}
	else if (m < n)
	{
		printf("The sum of the elements on the main diagonal is less than the sum of the elements on the minor diagonal");
	}
	else
	{
		printf("The sum of the elements on the main diagonal is equal to the sum of the elements on the minor diagonal");
	}
}
