#include <stdio.h>

main()
{
	int x = 3, y = 3, z = 1, i;
	for (i = 1; i <= y; i++)
		z *= x;
	printf("%d", z);
}
