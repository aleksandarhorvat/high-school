#include <stdio.h>
#include <string.h>

struct student
{
	char name[30];
	char lastName[30];
	char gender;
	float average;
	int grade;
};
main()
{
	struct student x[30], temp;
	int n, i, j, b1, b2;
	float max;
	printf("Enter the number of the student: ");
	scanf("%d", &n);
	printf("Enter student data\n");
	//entering data about students
	for (i = 0; i < n; i++)
	{
		printf("\nName: ");
		scanf("%s", &x[i].name);
		printf("Last name: ");
		scanf("%s", &x[i].lastName);
		printf("Gender (M or F): ");
		scanf(" %c", &x[i].gender);
		printf("Average grade: ");
		scanf("%f", &x[i].average);
		printf("Grade: ");
		scanf("%d", &x[i].grade);
	}

	printf("\n\n===================================================================================\n\n");

	b1 = 0;
	for (i = 0; i < n; i++)
		if (x[i].grade == 4) b1++;
	printf("\n1. Number of 4th grade students: %d\n", b1);

	b2 = 0;
	for (i = 0; i < n; i++)
		if (x[i].gender == 'M' || x[i].gender == 'm')
			b2++;
	printf("\n2. Number of male students is: %d\n", b2);

	printf("\n3. Names of students who have excellent results: \n");
	for (i = 0; i <= n; i++)
		if (x[i].average >= 4.5)
			printf("%s\n", x[i].name);

	max = x[0].average;
	for (i = 1; i < n; i++)
		if (x[i].average > max)
			max = x[i].average;
	printf("\n4. Name/names of students with the best average grade: \n");
	for (i = 0; i <= n; i++)
		if (x[i].average == max)
			printf("%s\n", x[i].name);

	for (i = 0; i < n; i++)
		for (j = i + 1; j < n; j++)
			if (strcmp(x[i].lastName, x[j].lastName) > 0)
			{
				temp = x[i];
				x[i] = x[j];
				x[j] = temp;
			}

	printf("\n5. Names of students sorted by last name (alphabetical order): \n");
	for (i = 0; i < n; i++)
		printf("%d. %s \n", i + 1, x[i].name);

	for (i = 0; i < n; i++)
		for (j = i + 1; j < n; j++)
			if (x[i].grade < x[j].grade)
			{
				temp = x[i];
				x[i] = x[j];
				x[j] = temp;
			}

	printf("\n5. a) Names of students sorted by grade: \n");
	for (i = 0; i < n; i++)
		printf("%d. %s \n", i + 1, x[i].name);
	printf("\n\n===================================================================================\n\n");
}
