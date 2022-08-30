#include <stdio.h>

main()
{
	int i, j, a[5] = { 2, 1, 0, -1, -2 };
	for (i = 0; i < 4; i++)
		for (j = i + 1; j < 5; j++)
			if (a[i] > a[j])
			{
				int t = a[i];
				a[i] = a[j];
				a[j] = t;
			}

	for (i = 0; i < 5; i++)
		printf("%d\n", a[i]);
}
