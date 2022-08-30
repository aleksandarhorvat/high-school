#include <stdio.h>
#include <stdlib.h>
#include <time.h>

main()
{
	int i, a[20];
	FILE *f = fopen("numbers.txt", "w");
	if (f == NULL)
	{
		printf("Error opening numbers.txt file for writing\n");
		exit(1);
	}

	srand(time(0));
	for (i = 0; i < 10; i++)
		fprintf(f, "%d\n", (rand() % 90) + 10);
	fclose(f);
	f = fopen("numbers.txt", "r");
	if (f == NULL)
	{
		printf("Error opening numbers.txt file for reading\n");
		exit(1);
	}

	for (i = 0; i < 20; i = i + 2)
	{
		a[i] = fgetc(f);
		a[i + 1] = fgetc(f);
		printf("From %c and %c bigger one is: ", a[i], a[i + 1]);
		if (a[i] > a[i + 1])
			printf("%c\n", a[i]);
		else
			printf("%c\n", a[i + 1]);
		fgetc(f);
	}

	fclose(f);
}
