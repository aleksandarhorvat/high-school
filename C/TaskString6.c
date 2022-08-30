#include <ctype.h>
#include <stdio.h>

main()
{
	int c;
	while ((c = getchar()) != EOF)
	{
		if (islower(c))	//if the character is a lowercase character
			putchar(toupper(c)); //convert to uppercase
		else if (c == '\n')
			putchar('\n');
		else
			putchar(c);
	}
}
