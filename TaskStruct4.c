#include <stdio.h>
#include <string.h>

struct worker
{
	char name[30];
	char gender;
	int workExperience, pql;
	float salary;
};
main()
{
	FILE *f = fopen("data2.txt", "r");
	struct worker x[50], temp;
	int i, j, b1, b2, max, choice;
	float average;
	//uploading data from the file about workers
	for (i = 0; i < 10; i++)
	{
		fscanf(f, "%s", &x[i].name);
		fscanf(f, " %c", &x[i].gender);
		fscanf(f, "%d", &x[i].workExperience);
		fscanf(f, "%d", &x[i].pql);
		fscanf(f, "%f", &x[i].salary);
	}

	printf("\n\n=============================================================\n\n");
	printf("Select view:\n\n");
	printf("1 - number of employees who have more than 5 years of service\n");
	printf("2 - average employee salary:\n");
	printf("3 - names of workers with the highest degree\n");
	printf("4 - number of women with more than 20 years of work experience\n");
	printf("5 - display of workers in alphabetical order\n\n");
	do {
		printf("Enter the number of the desired option: ");
		scanf("%d", &choice);
		switch (choice)
		{
			case 1:
				b1 = 0;	//number of workers with more than 5 years of work experience
				for (i = 0; i < 10; i++)
					if (x[i].workExperience > 5)
						b1++;
				printf("\nNumber of workers with more than 5 years of work experience: %d\n", b1);
				break;
			case 2:
				average = 0;	//average employee salary
				for (i = 0; i < 10; i++)
					average += x[i].salary;
				printf("\nAverage employee salary: %.2f dollars\n", average / 10);
				break;
			case 3:
				max = x[0].pql;	//workers with maximum pql
				for (i = 1; i < 10; i++)
					if (x[i].pql > max)
						max = x[i].pql;
				printf("\nNames of workers with the highest degree:\n");
				for (i = 0; i < 10; i++)
					if (x[i].pql == max)
						printf("%s\n", x[i].name);
				break;
			case 4:
				b2 = 0;	// number of women with more than 20 years of working experience
				for (i = 0; i <= 10; i++)
					if ((x[i].gender == 'F' || x[i].gender == 'f') && x[i].workExperience > 20)
						b2++;
				printf("\nNumber of women with more than 20 years of working experience: %d\n", b2);
				break;
			case 5:
				for (i = 0; i < 10; i++)
					for (j = i + 1; j < 10; j++)
						if (strcmp(x[i].name, x[j].name) > 0)
						{
							temp = x[i];
							x[i] = x[j];
							x[j] = temp;
						}

				printf("\nWorkers sorted alphabetically:\n\n");
				for (i = 0; i < 10; i++)
					printf("%d. %s \n", i + 1, x[i].name);
				break;
		}

		printf("\n\n=============================================================\n\n");
	}

	while (choice <= 5 && choice > 0);
}
