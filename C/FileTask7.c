//5. Write a program that will from the results.txt file (which contains 10 numbers between 0 and 100)
//read the numbers and print them on the screen in descending order.
#include <stdio.h>
#include <stdlib.h>	//we have an exit function

main()
{
	int i, j;
	int a[10];
	FILE *f = fopen("results.txt", "r");
	if (f == NULL)
	{
		printf("Error opening file results.txt for reading\n");
		exit(1);
	}

	while (fscanf(f, "%d", &a[i]) == 1)
		i++;
	fclose(f);
	for (i = 0; i < 10; i++)
		for (j = i + 1; j < 10; j++)
			if (a[j] > a[i])
			{
				int b = a[i];
				a[i] = a[j];
				a[j] = b;
			}

	for (i = 0; i < 10; i++)
		printf("%d\n", a[i]);
}
