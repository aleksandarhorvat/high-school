#include <stdio.h>
#define PI 3.14
void ball(float r, float *pP, float *pV)
{
	*pP = 4 *r *r * PI;
	*pV = r *r *r *PI *4 / 3;
}

main()
{
	float r, P, V;
	printf("Enter the radius: ");
	scanf("%f", &r);
	ball(r, &P, &V);
	printf("The volume: %.2f\n", V);
	printf("Surface area: %.2f", P);
}
