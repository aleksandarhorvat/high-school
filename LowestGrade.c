//Ocene i najmanja ocena
#include <stdio.h>

main()
{
	int n, i, min;
	printf("Enter the number of array elements:");
	scanf("%d", &n);
	int a[n];
	for (i = 0; i < n; i = i + 1)
	{
		printf("Enter %d. grade:", i + 1);
		scanf("%d", &a[i]);
	}

	min = a[0];
	for (i = 1; i < n; i++)
	{
		if (a[i] < min)
			min = a[i];
	}

	printf("The lowest grade is %d", min);
}
