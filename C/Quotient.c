#include <stdio.h>

main()
{
	float a, b, c;
	printf("Enter the first number: ");
	scanf("%f", &a);
	printf("Enter another number: ");
	scanf("%f", &b);
	c = a / b;
	printf("The value of the quotient is %.2f", c);
}
