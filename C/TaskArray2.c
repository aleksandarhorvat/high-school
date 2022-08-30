#include <stdio.h>
#include <stdbool.h>

main()
{
	int a[10], i, givenNumber;
	bool check = true;
	for (i = 0; i < 10; i++)
	{
		printf("Enter %d. number: ", i + 1);
		scanf("%d", &a[i]);
	}

	printf("Enter the value of the given number: ");
	scanf("%d", &givenNumber);
	for (i = 0; i < 10; i++)
	{
		if (givenNumber == a[i])
		{
			printf("The given number %d is present in the array and its index is: %d\n", givenNumber, i);
			check = false;
		}
	}

	if (check)
		printf("The given number %d is not present in the array", givenNumber);
}
