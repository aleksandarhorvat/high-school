#include <stdio.h>

main()
{
	int i, x, a[5] = { 1, 2, 3, 2, 4 };
	x = a[0];
	for (i = 1; i < 5; i++)
		if (a[i] > x)
			x = a[i];
	printf("%d", x);
}
