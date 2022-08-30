#include <stdio.h>

main()
{
	int i, j, s1 = 0, s2 = 0, n;
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

		if (s1 > s2)
			printf("The sum of the elements on the main diagonal is: %d and is greater than the sum of the elements on the side diagonal", s1);
		else if (s2 > s1)
			printf("The sum of the elements on the side diagonal is: %d and is greater than the sum of the elements on the main diagonal", s2);
		else
			printf("The sum of the elements on the main diagonal and the sum of the elements on the minor diagonal are the same and sum is: %d", s1);
	}
	else
	{
		printf("You have entered the wrong number of columns and rows.");
	}
}
