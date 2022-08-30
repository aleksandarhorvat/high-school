#include <stdio.h>

main()
{
	int n, i;
	printf("Enter how long your string will be: ");
	scanf("%d", &n);
	int a[n];
	for (i = 0; i < n; i++)
	{
		printf("\nEnter the value %d. array element: ", i + 1);
		scanf("%d", &a[i]);
	}

	printf("------------------------------------------------");
	for (i = 0; i < n; i++)
	{
		if (a[i] == a[i + 2] && a[i] != a[i + 1])
		{
			printf("\nBoomerang is: %d %d %d", a[i], a[i + 1], a[i + 2]);
		}
	}
}
