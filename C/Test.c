#include <stdio.h>

main()
{
	printf("Enter ur n: ");
	long n;
	long count = 1;
	scanf("%d", &n);
	do {
		if (n == 1)
			break;
		else if (n % 2 == 0)
			n = n / 2;
		else
			n = (n *3) + 1;
		printf("%ld. N is now : %ld\n", count, n);
		count++;
	} while (n != 1);
	printf("\nWe did it");
}
