#include <stdio.h>

main()
{
	int n;
	printf("Enter the number of points:");
	scanf("%d", &n);
	if (n < 51)
		printf("Grade is 1 ");
	else if (n < 61)
		printf("Grade is 2 ");
	else if (n < 71)
		printf("Grade is 3 ");
	else if (n < 81)
		printf("Grade is 4 ");
	else
		printf("Grade is 5 ");
}
