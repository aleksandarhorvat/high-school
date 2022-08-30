#include <stdio.h>

main()
{
	int c;
	while ((c = getchar()) != EOF) //as long as a character is entered or until ctrl+z is entered
	{
		if ('a' <= c && c <= 'z') //for all characters from a to z
			putchar(c - 32); //replace with the character that is 32 characters behind in the ASCII table
		else if (c == '\n')	//when a new line is added, print a new line
			putchar('\n');
		else
			putchar(c);
	}
}
