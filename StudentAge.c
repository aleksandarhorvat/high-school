#include <stdio.h>

main()
{
	int i, n, a[30], s = 0;
	printf("Enter the number of the student: ");
	scanf("%d", &n);
	for (i = 0; i < n; i++)
	{
		printf("Enter age of %d. student: ", i + 1);
		scanf("%d", &a[i]);
		s += a[i];
	}

	printf("The sum of the years of all students is %d", s);
}
