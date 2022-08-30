#include <stdio.h>
#include <stdlib.h> //Because of the exit function

main()
{
	int i, br;
	/*We open the file named "data.txt" for writing*/
	FILE *f = fopen("data.txt", "w");
	/*If the opening failed, fopen returns NULL. In that case, we report an error and execute the program*/
	if (f == NULL)
	{
		printf("Error opening data.txt file for writing\n");
		exit(1);
	}

	/*We write in the file the first 10 natural numbers (each in a separate row)*/
	for (i = 0; i < 10; i++)
		fprintf(f, "%d\n", i);
	/*We are closing the file*/
	fclose(f);
	/*We open the file named data.txt for reading*/
	f = fopen("data.txt", "r");
	/*If the opening failed, fopen returns NULL. In that case, we report an error and end the program*/
	if (f == NULL)
	{
		printf("Error opening file data.txt for reading\n");
		exit(1);
	}

	/*We read numbers from the file until we reach the end and print them to the standard output*/
	/*We are trying to read the number*/
	while (fscanf(f, "%d", &br) == 1)
		/*We print the read number*/
		printf("Read : %d\n", br);
	/*We are closing the file*/
	fclose(f);
}
