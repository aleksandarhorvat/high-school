#include <stdio.h>
#include <math.h>

void triangle(float a, float b, float *pO, float *pP)
{
	float c;
	c = sqrt(a *a + b *b);
	*pP = (a *b) / 2;
	*pO = a + b + c;
}

main()
{
	float a, b, c, P, O;
	printf("Enter the legs of the triangle: ");
	scanf("%f%f", &a, &b);
	triangle(a, b, &O, &P);
	printf("Circumference: %.2f\n", O);
	printf("Surface area: %.2f", P);
}
