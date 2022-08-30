#include <stdio.h>
#include <stdlib.h>
#include <time.h>

main()
{
	int b;
	srand(time(NULL));
	b = rand() % 3 + 1;
	printf("%d", b);
}
