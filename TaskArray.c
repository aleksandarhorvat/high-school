#include <stdio.h>

main()
{
	int a[10], i;
	for (i = 0; i < 10; i++)
	{
		printf("Enter %d. number: ", i + 1);
		scanf("%d", &a[i]);
	}

	printf("\nThe elements of the array you entered are: ");
	for (i = 0; i < 10; i++)
	{
		printf("\na[%d]=%d", i, a[i]);
	}
}
