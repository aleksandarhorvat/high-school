//A program that determines the total number of symbols in the text, the number of letters, words and sentences.
#include <stdio.h>
#include <string.h>
#include <ctype.h>
#include <conio.h>

main()
{
	char tekst[1000];
	int i, n, symbol = 0, letter = 0, word = 0, sentence = 0, state, wc = 0;
	printf("Enter text: ");
	gets(tekst);
	n = strlen(tekst);
	for (i = 0; i < n; i++)
	{
		if (isalpha(tekst[i]))
			letter++;
		if (tekst[i] == ' ' || tekst[i] == '\n' || tekst[i] == '\t')
			state = 0;

		else if (state == 0)
		{
			state = 1;
			wc++;
		}
	}

	state = 1;
	for (i = 0; i < n; i++)
	{
		if (state == 1)
		{
			if (islower(tekst[i]) == 0)
				state = 0;
		}
		else if (state == 0)
			if (tekst[i] == '.' || tekst[i] == '!' || tekst[i] == '?')
			{
				state = 1;
				sentence++;
			}
	}

	symbol = n;
	word = wc;

	printf("Number of symbols:%d \nNumber of letters:%d \nNumber of sentences:%d \nNumber of sentences:%d", symbol, letter, word, sentence);
}
