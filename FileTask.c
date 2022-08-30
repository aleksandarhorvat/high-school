//Program that reads words from the given file "text.txt" and determines the average number of letters in words of even length.
#include <stdio.h>
#include <string.h>

int main()
{
	FILE *in ;
	char word[20];
	int length;
	int totalLength = 0;
	int avarage;
	int numberWords = 0;
	//opening text file 'text.txt'
	if ((in = fopen("text.txt", "r")) == NULL)
	{
		printf("The input file is not open!");
		return 1;
	}

	//reading words from the file text.txt
	while (!feof(in))
	{
		fscanf(in, "%s", word);
		//reading the length of the word
		length = (int) strlen(word);
		//if length is an even number
		if (length % 2 == 0)
		{
			totalLength += length;
			numberWords++;
			printf("%s: thare are %d letters \n", word, length);
		}
	}

	avarage = totalLength / numberWords;
	printf("\nThere are %d words with an even number of letters in the input file,", numberWords);
	printf("which have a total of %d letters!\n", totalLength);
	printf("The average length of words with an even number of letters in the file is %d", avarage);
	fclose(in);
	return 0;
}
