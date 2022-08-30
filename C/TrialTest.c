#include <stdio.h>

main()
{
	int N, i, zdigitN, zdigitB, temp;
	char c;
	int L[1000];
	do {
		do {
			printf("Enter a natural number between 8 and 1000: ");
			scanf("%d", &N);
		} while (N < 8 || N > 1000);

		zdigitN = 0;
		temp = N;

		while (temp > 0)
		{
			zdigitN += temp % 10;
			temp /= 10;
		}

		for (i = 0; i < N; i++)
		{
			do {
				printf("Enter the array element at index %d: ", i);
				scanf("%d", &L[i]);
			} while (L[i] <= 0);
		}

		for (i = 0; i < N; i++)
		{
			zdigitB = 0;
			temp = L[i];
			while (temp > 0)
			{
				zdigitB = 0;
				temp = L[i];
				while (temp > 0)
				{
					zdigitB += temp % 10;
					temp /= 10;
				}

				if (zdigitB < zdigitN)
					printf("%d \n", L[i]);
			}
		}

		printf("\n\nDo you want to start the program again? (Y|N): ");
		scanf("%c\n", &c);
	} while (c == 'Y' || c == 'y');
}
