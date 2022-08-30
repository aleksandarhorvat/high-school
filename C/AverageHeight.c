//Prosecna visina
#include <stdio.h>

main()
{
	int i;
	float pv;
	int a[5];
	for (i = 0, pv = 0; i < 5; i = i + 1)
	{
		printf("Enter the height of %d. student:", i + 1);
		scanf("%d", &a[i]);
		pv = pv + a[i];
	}

	printf("The average height of 5 students is %.2f", pv / 5);
}
