#include <stdio.h>

main()
{
	printf("Enter (r)ectangle, (t)riangle or (c)ircle: ");
	char c = getc(stdin);
	switch (c)
	{
		case 'R':
		case 'r':
			printf("Rectangle ");
			break;
		case 'T':
		case 't':
			printf("triangle ");
			break;
		case 'C':
		case 'c':
			printf("circle ");
			break;
		default:
			printf("It is not a geometric figure");
	}
}
