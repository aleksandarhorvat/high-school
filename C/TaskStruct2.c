#include <stdio.h>
#include <string.h>

struct worker
{
	char name[30];
	char gender;
	int workExperience;
	int pql;
	float salary;
};	//structure worker
main()
{
	struct worker x[50], pom;
	int n, i, j, b1, b2, max;
	float average;
	printf("Enter the number of workers: ");
	scanf("%d", &n);
	printf("Enter information about workers\n");
	//entering data about workers
	for (i = 0; i < n; i++)
	{
		printf("\nName of %d. worker: ", i + 1);
		scanf("%s", &x[i].name);
		printf("Gender: ");
		scanf(" %c", &x[i].gender);
		printf("Years of work experience: ");
		scanf("%d", &x[i].workExperience);
		printf("Professional qualifications level: ");
		scanf("%d", &x[i].pql);
		printf("Salary: ");
		scanf("%f", &x[i].salary);
	}

	printf("\n\n=============================================\n\n");
	b1 = 0;	//number of workers with more than 5 years of work experience
	for (i = 0; i < n; i++)
		if (x[i].workExperience > 5)
			b1++;
	printf("\n1. The number of workers with more than 5 years of work experience: %d\n", b1);
	average = 0; //the average salary of a worker
	for (i = 0; i < n; i++)
		average += x[i].salary;
	average = average / n;
	printf("\n2. Average employee salary: %.2f dollars\n", average);
	max = x[0].pql;	//workers with maximum pql
	for (i = 1; i < n; i++)
		if (x[i].pql > max)
			max = x[i].pql;
	printf("\n3. Names of workers with the highest degree of professional education: \n");
	for (i = 0; i <= n; i++)
		if (x[i].pql == max)
			printf("%s\n", x[i].name);
	b2 = 0;	//the number of women who have more than 20 years of working experience
	for (i = 0; i < n; i++)
		if ((x[i].gender == 'F' || x[i].gender == 'f') && x[i].workExperience > 20)
			b2++;
	printf("\n4. Number of women with more than 20 years of work experience: %d\n", b2);
	//alphabetical sorting
	for (i = 0; i < n; i++)
		for (j = i + 1; j < n; j++)
			if (strcmp(x[i].name, x[j].name) > 0)
			{
				pom = x[i];
				x[i] = x[j];
				x[j] = pom;
			}

	printf("\n5. Workers sorted alphabetically: \n");
	for (i = 0; i < n; i++)
		printf("%d. %s \n", i + 1, x[i].name);
	printf("\n\n=============================================\n\n");
}
