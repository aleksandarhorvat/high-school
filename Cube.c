#include <stdio.h>

void cube(float a, float b, float c, float *pP, float *pV)
{
	*pP = 2 *(a *b + a *c + b *c);
	*pV = a *b * c;
}

main()
{
	float a, b, c, P, V;
	printf("Enter page lengths: ");
	scanf("%f%f%f", &a, &b, &c);
	cube(a, b, c, &P, &V);
	printf("Circumference: %.2f\n", V);
	printf("Surface area: %.2f", P);
}
