#include <stdio.h>

void square(float a, float *pP)
{
	*pP = a * a;
}

main()
{
	float a, P;
	printf("Enter the page length: ");
	scanf("%f", &a);
	square(a, &P);
	printf("Surface area: %.2f", P *6);
}
