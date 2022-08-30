//A program that will write the entered text in lowercase letters and without spaces
#include <stdio.h>
#include <string.h>
#include <ctype.h>
#include <conio.h>

main()
{
	char word[1000];
	int i, n, j;
	printf("Enter a sentence:");
	gets(word);
	n = strlen(word);
	for (i = 0; i < n; i++)
		if (word[i] == ' ')
		{
			for (j = i; j < n; j++)
				word[j] = word[j + 1];
		}

	for (i = 0; i < n; i++)
		word[i] = tolower(word[i]);
	puts(word);
}
