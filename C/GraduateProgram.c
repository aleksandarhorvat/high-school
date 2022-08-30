#include <stdio.h>
#include <stdlib.h>
#include <time.h>

struct worker
{
	//structure data declaration
	char name[30], surname[30], gender;
	int workExperience, pqe;
};
//function to generate job name
char *jobName()
{
	int rng;
	char *s;
	//generate a pseudo-random number
	srand(time(NULL));
	rng = rand() % 5 + 1;
	//we insert that pseudo-random number into the switch, in order to take one of the offered strings
	switch (rng)
	{
		case 1:
			s = "Baker";
			return s;
		case 2:
			s = "Programmer";
			return s;
		case 3:
			s = "Doctor";
			return s;
		case 4:
			s = "Courier";
			return s;
		case 5:
			s = "Architect";
			return s;
	}
}

//function to generate the required work experience for the job
int workExperience()
{
	int rng, work;
	//generate a pseudo-random number
	srand(time(NULL));
	rng = rand() % 5 + 1;
	//we insert that pseudo-random number into the switch, in order to take one of the offered values
	switch (rng)
	{
		case 1:
			work = 5;
			break;
		case 2:
			work = 10;
			break;
		case 3:
			work = 15;
			break;
		case 4:
			work = 25;
			break;
		case 5:
			work = 20;
			break;
	}

	return work;
}

//function for generating the necessary degree of professional Education for the job
int degreeOfProfessionalEducation()
{
	int rng, stp;
	//generate a pseudo-random number
	srand(time(NULL));
	rng = rand() % 5 + 1;
	//we insert that pseudo-random number into the switch, in order to take one of the offered values
	switch (rng)
	{
		case 1:
			stp = 4;
			break;
		case 2:
			stp = 5;
			break;
		case 3:
			stp = 6;
			break;
		case 4:
			stp = 7;
			break;
		case 5:
			stp = 8;
			break;
	}

	return stp;
}

//function for generating the preferred gender of the worker
char workerGender()
{
	int rng;
	char p;
	//generate a pseudo-random number
	srand(time(NULL));
	rng = rand() % 2 + 1;
	//we insert that pseudo-random number into the switch, in order to take one of the offered characters
	switch (rng)
	{
		case 1:
			p = 'M';
			break;
		case 2:
			p = 'F';
			break;
	}

	return p;
}

//main function
main()
{
	struct worker x[30];
	int n, i, rng, work, stp;
	char *s, p, q[100];

	printf("Enter the number of employees: ");
	scanf("%d", &n);

	printf("------------------------------------------------");
	//write data into the structure
	for (i = 0; i < n; i++)
	{
		printf("\nEnter the name of %d. employee: ", i + 1);
		scanf("%s", &x[i].name);
		printf("Enter last name of %d employee: ", i + 1);
		scanf("%s", &x[i].surname);
		printf("Enter gender %d. of workers (M/F): ", i + 1);
		scanf(" %c", &x[i].gender);
		printf("Enter work experience of %d. employee: ", i + 1);
		scanf("%d", &x[i].workExperience);
		printf("Enter the degree of professional education of %d. workers: ", i + 1);
		scanf("%d", &x[i].pqe);
		printf("------------------------------------------------");
	}

	//return data from functions
	s = jobName();
	work = workExperience();
	stp = degreeOfProfessionalEducation();
	p = workerGender();
	//opening the file to write data into it
	FILE *f = fopen("ad.txt", "w");
	fprintf(f, "%s\n", s);
	fprintf(f, "%c", p);
	fputs(" - Preferred gender of the worker\n", f);
	fprintf(f, "%d years", work);
	fputs(" - Required working experience\n", f);
	fprintf(f, "%d years", stp);
	fputs(" - Required degree of professional education\n", f);
	fclose(f);
	//closing and reopening the file to read data from it
	f = fopen("ad.txt", "r");
	fscanf(f, "%s", q);
	printf("\nWorkers who can do the job: %s\n", q);
	fscanf(f, "%d", &work);
	fscanf(f, "%d", &stp);
	fscanf(f, "%c", &p);
	//verifies which worker meets the given conditions
	int temp = 0;
	for (i = 0; i < n; i++)
	{
		if (x[i].gender == p && x[i].workExperience >= work && x[i].pqe >= stp)
		{
			printf("\n%s %s\n", x[i].name, x[i].surname);
			temp = 1;
		}
	}

	if (!temp)
		printf("\nThere are no workers who meet the condition!");
	//closes the file
	fclose(f);
}
