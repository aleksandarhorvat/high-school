#include <stdio.h>
#include <ctype.h>

int sumOfDigits(const char array[])
{
	int i, n = 0;
	for (i = 0; i < 100; i++) //for all characters
		n += isdigit(array[i]) != 0; //add one to n if the character is not equal to the number
	return n;
}

main()
{
	char text[100];
	gets(text);
	printf("The sum of digits in the text is: %d", sumOfDigits(text)); //displays the number n
}
