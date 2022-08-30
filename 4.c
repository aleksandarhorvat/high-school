#include <stdio.h>

main()
{
	int i, a[5] = { 1, 2, 3, 2, 4 };
	for (i = 0; i < 5; i++)
		if (a[i] == 2)
		{
			printf("%d", i);
			break;
		}
}
