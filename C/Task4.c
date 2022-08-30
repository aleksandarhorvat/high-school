#include <stdio.h>

main()
{
	int i, j, n, m, x, temp, s = 0;
	printf("Enter the number of students: ");
	scanf("%d", &m);

	printf("Enter the number of the month of the year: ");
	scanf("%d", &n);

	printf("Enter the number of the month being examined: ");
	scanf("%d", &x);

	double plate[n][m];

	for (i = 0; i < n; i++)
	{
		temp = 0;
		for (j = 0; j < m; j++)
		{
			printf("Enter the grade of the student: ");
			scanf("%lf", &plate[i][j]);
			if (temp < x)
			{
				s = s + plate[i][j];
				temp++;
			}
		}
	}

	printf("The average grade of the students is %.2f", (float) s / (m *x));

}
