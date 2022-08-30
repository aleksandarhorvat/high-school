#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main()
{
	int length, i;
	char str1[200], *str2;

	printf("Enter a string: ");
	scanf("%s", str1);
	length = strlen(str1);
	str2 = (char*) malloc(length + 1);

	for (i = 0; i < length; i++)
	{
		str2[i] = str1[length - i - 1];
	}

	str2[length] = 0;

	printf("Reverse: %s", str2);

	if (strcasecmp(str1, str2) != 0)

		printf("\nThe word is not a palindrome!");
	else
		printf("\nThe word is a palindrome!");

	return 0;
}
