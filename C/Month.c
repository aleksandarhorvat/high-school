#include <stdio.h>

main()
{
	int a, b;
	printf("Enter the serial number of the month:");
	scanf("%d", &a);
	switch (a)
	{
		case 1:
		case 3:
		case 5:
		case 7:
		case 9:
		case 11:
			printf("A month has 31 days");
			break;
		case 4:
		case 6:
		case 8:
		case 10:
		case 12:
			printf("A month has 30 days");
			break;
		case 2:
			printf("Is it a leap year, b=1 (yes), b=2 (no): ");
			scanf("%d", &b);
			if (b == 1)
				printf("It has 29");
			else if (b == 2)
				printf("It has 28");
			break;
		default:
			printf("You entered the wrong number");
	}
}
