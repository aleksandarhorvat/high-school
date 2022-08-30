#include <stdio.h>
#include <stdlib.h>
#include <time.h>

main()
{
	int broj, uneti, i, s = 0;
	srand(time(NULL));
	broj = rand() % 10;
	printf("Enter the number of trys: ");
	scanf("%d", &i);
	do {
		printf("Enter the number: ");
		scanf("%d", &uneti);
		if (uneti > broj)
		{
			printf("You entered a higher number\n");
		}
		else if (uneti < broj)
		{
			printf("You entered a lower number\n");
		}
		else
		{
			printf("You have entered the correct number!\n");
			break;
		}
		s++;
	}
	while (s < i);
	if (s == i)
	{
		printf("You didn't guess right");
	}
}
