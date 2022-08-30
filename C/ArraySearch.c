#include <stdio.h>

int organized(int a[], int n)
{
	int i;
	for (i = 0; i < (n - 1); i++)
		if (a[i] > a[i + 1])
			return 0;

	return 1;
}

int sektra(int a[], int n, int b)
{
	int i;
	for (i = 0; i < n; i++)
		if (a[i] == b)
			return 1;
	return 0;
}

int bintra(int a[], int n, int b)
{
	int d = 0, g = n - 1, s;
	while (d <= g)
	{
		s = (d + g) / 2;
		if (a[s] == b)
			return 1;
		else
		{
			if (a[s] > b)
				g = s - 1;
			else
				d = s + 1;
		}
	}

	return 0;
}

main()
{
	int ima, n, i, b, met;
	printf("Enter n: ");
	scanf("%d", &n);
	int a[n];
	for (i = 0; i <= n - 1; i++)
	{
		printf("Enter the value of %d. element: ", i + 1);
		scanf("%d", &a[i]);
	}

	printf("Enter the type of search you want (1-binary/0-sequential): ");
	scanf("%d", &met);
	printf("Enter the element you are looking for: ");
	scanf("%d", &b);
	if (met == 0)
		ima = sektra(a, n, b);
	else
	{
		if (organized(a, n))
			ima = bintra(a, n, b);
		else
			ima = -1;
	}

	if (ima > 0)
		printf("The array contains that number");
	else if (ima == -1)
		printf("Binary search cannot find the element if array is not organized");
	else
		printf("The array does not contain that number");
}
