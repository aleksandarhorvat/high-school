#include <stdio.h>
#include <ctype.h>

int numberDigits(char s[])
{
	int i, n = 0;
	for (i = 0; s[i] != '\0'; i++) //for all characters up to the end of the string
		if (isdigit(s[i]) != 0)	//if the character is a digit then it is not equal to zero
			n++	//add one to n
	return n;
}

main()
{
	char s[80];
	gets(s);
	printf("The number of digits in the text is: %d", numberDigits(s));	//displays the number n
}
