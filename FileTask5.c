#include <stdio.h>
#include <stdlib.h>

main()
{
	FILE *dat;
	char name[50];
	int grade;
	float points;
	dat = fopen("grades.txt", "r");
	if (dat == NULL)
	{
		printf("Error in opening file\n");
		exit(1);
	}

	while (fscanf(dat, "%s %d %f\n", name, &grade, &points) != EOF)
		printf("%s %d %.2f\n", name, grade, points);
	fclose(dat);
}
