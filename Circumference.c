#include <stdio.h>
#include <math.h>

float circumference(int a, int b);

main()
{
	int x, y;
	printf("Enter the value of cathetus: ");
	scanf("%d%d", &x, &y);
	printf("Circumference is %.2f", circumference(x, y));
}

float circumference(int a, int b)
{
	float c, O;
	c = sqrt(a *a + b *b);
	O = a + b + c;
	return O;
}
