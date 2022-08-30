//A program that determines how many times a given letter (entered via the keyboard) appears in a given text.
#include <string.h>
#include <stdio.h>

int main()
{
	char s[1000], c;
	int i, count = 0;

	printf("Enter a string : ");
	gets(s);
	printf("Enter the letter to be searched for: ");
	c = getchar();

	for (i = 0; s[i]; i++)
	{
		if (s[i] == c)
		{
			count++;
		}
	}

	printf("The letter '%c' has appeared %d times \n ", c, count);

	return 0;
}
