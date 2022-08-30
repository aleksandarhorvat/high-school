#include <stdio.h>
#include <string.h>
#include <limits.h>

struct student
{
	char name[30];
	char surname[30];
	int id;
	float average;
};
main()
{
	FILE *f = fopen("data.txt", "r");
	struct student x[50], pom;
	int i, j, b1, b2, temp = 0, max = INT_MIN, choice;
	float average;
	//uploading data from the file about students
	for (i = 0; i < 10; i++)
	{
		fscanf(f, "%s", &x[i].name);
		fscanf(f, "%s", &x[i].surname);
		fscanf(f, "%d", &x[i].id);
		fscanf(f, "%f", &x[i].average);
	}

	printf("\n\n======================================================\n\n");
	printf("Choose what you want to be displayed:\n\n");
	printf("1 - writes the names of students in alphabetical order:\n");
	printf("2 - writes the average grade of the whole class:\n");
	printf("3 - prints the data of students with the best results:\n");
	do {
		printf("Enter the number of the desired option: ");
		scanf("%d", &choice);
		switch (choice)
		{
			case 1:
				for (i = 0; i < 10; i++) //names of students sorted by last name (alphabetical order)
					for (j = i + 1; j < 10; j++)
						if (strcmp(x[i].name, x[j].name) > 0)
						{
							pom = x[i];
							x[i] = x[j];
							x[j] = pom;
						}

				printf("\nNames of students sorted by last name (alphabetical order): \n\n");
				for (i = 0; i < 10; i++)
					printf("%d. %s \n", i + 1, x[i].name);
				break;
			case 2:
				average = 0; //the average grade the whole class
				for (i = 0; i < 10; i++)
					average += x[i].average;
				printf("\nAverage grade of the whole class: %.2f\n", average / 10);
				break;
			case 3:
				for (i = 0; i < 10; i++)
					if (x[i].average > max)
					{
						max = x[i].average;
						temp = i;
					}

				printf("\nData of students with the best average grade: \n");
				printf("%s\n", x[temp].name);
				printf("%s\n", x[temp].surname);
				printf("%d\n", x[temp].id);
				printf("%f\n", x[temp].average);
		}

		printf("\n\n======================================================\n\n");
	}

	while (choice <= 3 && choice > 0);
}
