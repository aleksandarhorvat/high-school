#include <stdio.h>

main()
{
	int i, j, s1 = 0, s2 = 0, n, s;
	printf("Enter the number of columns and rows: ");
	scanf("%d", &n);
	if (n <= 100)
	{
		int a[n][n];
		for (i = 0; i < n; i++)
			for (j = 0; j < n; j++)
			{
				printf("Enter the matrix elements: ");
				scanf("%d", &a[i][j]);

				if (i == j) s1 = s1 + a[i][j];

				if (i + j == n - 1) s2 = s2 + a[i][j];
			}

		s = s1 - s2;
		printf("The difference of the sum of the diagonals is: %d", s);
	}
	else
	{
		printf("You have entered the wrong number of columns and rows.");
	}
}
