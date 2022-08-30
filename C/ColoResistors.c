#include <stdio.h>

main()

{
	int color;
	printf("Enter the resistor color number:");
	scanf("%d", &color);
	switch (color)
	{
		case 0:
			printf("Black");
			break;
		case 1:
			printf("Brown");
			break;
		case 2:
			printf("Red");
			break;
		case 3:
			printf("Orange");
			break;
		case 4:
			printf("Yellow");
			break;
		case 5:
			printf("Green");
			break;
		case 6:
			printf("Blue");
			break;
		case 7:
			printf("Purple");
			break;
		case 8:
			printf("Grey");
			break;
		case 9:
			printf("White");
			break;
		default:
			printf("Unfortunately, such a resistor does not exist");
	}
}
