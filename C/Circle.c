#include <stdio.h>
#define PI 3.14
void circle(float r, float *pP, float *pO)
{
	*pP = r *r * PI;
	*pO = 2 *r * PI;
}

main()
{
	float r, P, O;
	printf("Enter the radius: ");
	scanf("%f", &r);
	circle(r, &P, &O);
	printf("Circumference: %.2f\n", O);
	printf("Surface area: %.2f", P);
}
