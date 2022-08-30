//No arguments passed and no return value
#include <stdio.h>

void even();
main()
{
	even();
}

void even()
{
	int x;
	printf("Enter x: ");
	scanf("%d", &x);
	if (x % 2 == 0)
		printf("You entered an even number!");
	else
		printf("You entered an odd number!");

}
