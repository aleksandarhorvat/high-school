/*
Write a program that loads the dimension of the sequence 1 = K = 50, and then the sequence of natural numbers
smaller than 10000 of the given dimension K (run input control). Then it is necessary to print
on the screen all elements of the array that are divisible by the minimum element of the array. For example. for K = 7 and
sequence L =[7, 18, 4, 25, 3, 9, 11], the elements 18, 3 and 9 are printed, because the minimum element is 3.
*/
#include <stdio.h>

main()
{
	int K, i, j = 0;
	do {
		printf("\nEnter the dimension of the array K, so that it is valid 1 <= K<=50: ");
		scanf("%d", &K);
	} while (K < 1 || K > 50);
	int L[K];
	for (i = 0; i < K; i++)
	{
		do {
			printf("\Enter %d. digit of the array, so it is less than 1000: ", i + 1);
			scanf("%d", &L[i]);
		} while (L[i] > 1000);
	}

	int min = L[0];
	for (i = 1; i < K; i++)
	{
		if (min > L[i])
		{
			min = L[i];
		}
	}

	for (i = 0; i < K; i++)
	{
		if (L[i] % min == 0)
		{
			j = j + 1;
			printf("\n%d.Such an element: %d", j, L[i]);
		}
	}
}
