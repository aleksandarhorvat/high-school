#include <stdio.h>

int main()
{
	int i, n, min, s;
	printf("Enter the total number of numbers: ");
	scanf("%d", &s);
	printf("Enter the first number: ");
	scanf("%d", &n);
	min = n;
	for (i = 1; i <= s - 1; i++)
	{
		printf("Enter another number: ");
		scanf("%d", &n);
		if (n < min)
			min = n;
	}

	printf("The smallest number is %d", min);
	return 0;
}
