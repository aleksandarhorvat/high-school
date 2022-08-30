// Nizovi-min,max,aritmeticka sredina
#include <stdio.h>

main()
{
	int a[10], i, s, min, max;
	for (i = 0, s = 0; i < 10; i++)
	{
		printf("Enter %d. number: ", i + 1);
		scanf("%d", &a[i]);
	}

	max = min = a[0];
	for (i = 0; i < 10; i++)
	{
		s += a[i];
		if (max < a[i])
			max = a[i];
		else if (min > a[i])
			min = a[i];
	}

	printf("Minimum is %d\nMaximum is %d\nArithmetic mean is %f\n", min, max, (float) s / 10);

}
