#include <stdio.h>

main()
{
	char c;
	int i;
	printf("Table of ASCII codes: \n\n");
	for (c = ' '; c<' ' + 19; c++) //from the first character to the number of characters you want to have lines (19.)
	{
		for (i = 0; i < 77; i += 19) //for the first character up to the total number of characters (Total = row * column) minus the number of rows plus one (Do = Total - row+1), add 19 characters each
			printf("%4d. %c", c + i, c + i); //prints 19 characters each and their serial number
		putchar('\n'); //adds a new line
	}
}
