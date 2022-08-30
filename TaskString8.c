#include <stdio.h>
#include <ctype.h>

int numberDots(const char array[])
{
	int i, n = 0;
	for (i = 0; i < 100; i++) //for all characters
		if (array[i] == '.') //if the character is a dot
			n++; //add one to n
	return n;
}

main()
{
	char text[100];
	gets(text);
	printf("The number of sentences in the text is: %d", numberDots(text));	//displays the number n
}
