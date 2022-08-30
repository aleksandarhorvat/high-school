#include <stdio.h>

void rectangle(float a, float b, float *pO, float *pP)
{
	*pO = 2 *(a + b);
	*pP = a * b;
}

main()
{
	float a, b, O, P;
	printf("Enter page lengths: ");
	scanf("%f%f", &a, &b);
	rectangle(a, b, &O, &P);
	printf("Circumference: %.2f\n", O);
	printf("Surface area: %.2f", P);
}
