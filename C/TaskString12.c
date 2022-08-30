#include <ctype.h>
#include <stdio.h>

int numberWords(char s[])
{
	int i, n = 1;
	for (i = 0; s[i] != '\0'; i++)	//for all characters up to the end of the string
		if (isspace(s[i]) != 0)	//if the character is a space then it is not equal to zero
			n++; //add one to n
	return n;
}

main()
{
	char s[100];
	gets(s);
	printf("Broj reci u recenici je: %d", numberWords(s));	//displays the number n
}
