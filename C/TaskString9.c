#include <stdio.h>
#include <string.h>

main()
{
	char row[100], max[100] = " ";
	while (1)
	{
		gets(row); //takes a string row
		if (strcmp(row, "***") == 0)
			break;	//when the string line is equal to "***" it terminates the program
		if (strlen(row) > strlen(max))
			strcpy(max, row); //when string row is greater than string max, it overwrites string row into string max
	}

	puts(max); //prints the string max
}
