#include <stdio.h>
#include <math.h>

main()
{
	float x, y;

	printf("Enter x: ");
	scanf("%f", &x);
	if (x <= -5)
		y = x * x - 4;
	else if (x > -5 && x <= 10)
		y = 3 / x;
	else
		y = sqrt(x - 5) / 3;
	printf("y is equal %.2f", y);
}
