#include <stdio.h>
#include <ctype.h>

int numberLowecase(char s[])
{
	int i, n = 0;
	for (i = 0; s[i] != '\0'; i++)
		if (islower(s[i]) != 0)
			n++;
	return n;
}

int numberUppercase(char s[])
{
	int i, m = 0;
	for (i = 0; s[i] != '\0'; i++)
		if (isupper(s[i]) != 0)
			m++;
	return m;
}

int numberDigits(char s[])
{
	int i, p = 0;
	for (i = 0; s[i] != '\0'; i++)
		if (isdigit(s[i]) != 0)
			p++;
	return p;
}

int numberSpaces(char s[])
{
	int i, q = 0;
	for (i = 0; s[i] != '\0'; i++)
		if (isspace(s[i]) != 0)
			q++;
	return q;
}

main()
{
	char s[20];
	printf("Please enter your string: ");
	gets(s);
	printf("The number of lowercase letters in the text is %d\n", numberLowecase(s));
	printf("The number of uppercase letters in the text is %d\n", numberUppercase(s));
	printf("The number of digits in the text is %d\n", numberDigits(s));
	printf("The number of spaces in the text is %d\n", numberSpaces(s));
}
