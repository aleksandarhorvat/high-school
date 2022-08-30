#include <stdio.h>

main()
{
	int i, j, r1 = 0, r2 = 0, r3 = 0, k1 = 0, k2 = 0, k3 = 0;
	int A[3][3];
	for (i = 0; i < 3; i++)
		for (j = 0; j < 3; j++)
		{
			printf("Enter element of %d. row and of %d. column: ", i, j);
			scanf("%d", &A[i][j]);
		}

	for (i = 0; i < 3; i++)
	{
		k1 += A[i][0];
		k2 += A[i][1];
		k3 += A[i][2];
	}

	for (j = 0; j < 3; j++)
	{
		r1 += A[0][j];
		r2 += A[1][j];
		r3 += A[2][j];
	}

	int B[3] = { r1, r2, r3
	}, C[3] = { k1, k2, k3
	};
	printf("The elements of array B are: ");
	for (i = 0; i < 3; i++)
		printf("%d ", B[i]);
	printf("\nThe elements of array C are: ");
	for (i = 0; i < 3; i++)
		printf("%d ", C[i]);
}
