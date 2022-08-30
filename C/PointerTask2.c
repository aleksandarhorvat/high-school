#include <stdio.h>

void swap(int *a, int *b, int *temp)
{
	*temp = *a;
	*a = *b;
	*b = *temp;
}

main()
{
	int a = 3, b = 4, temp;
	swap(&a, &b, &temp);
	printf("a=%d\nb=%d", a, b);
}
