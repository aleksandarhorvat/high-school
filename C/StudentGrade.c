#include <stdio.h>

main()
{
	int a[30], i, n;
	printf("Enter the number of the student: ");
	scanf("%d", &n);
	for (i = 0; i < n; i++)
	{
		printf("Enter points of %d. student: ", i + 1);
		scanf("%d", &a[i]);
	}

	for (i = 0; i < n; i++)
	{
		if (a[i] >= 50)
			printf("%d.The student passed the exam\n", i + 1);
		else
			printf("%d.The student did not pass the exam\n", i + 1);
	}
}
