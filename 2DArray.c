#include <stdio.h>

main()
{
	int s = 0, i, j, m, n;
	printf("Enter the column number: ");
	scanf("%d", &m);
	printf("Enter the number of rows: ");
	scanf("%d", &n);
	int a[m][n];
	for (i = 0; i < m; i++)
	{
		for (j = 0; j < n; j++)
		{
			printf("Enter an element of %d. column and %d. row: ", i + 1, j + 1);
			scanf("%d", &a[i][j]);
			s += a[i][j];
		}
	}

	printf("Total sum is: %d", s);
}
