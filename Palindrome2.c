#include <stdio.h>
#include <string.h>

char s[50], c[50];
int main()
{
	gets(s);
	strcpy(c, s);
	for (int i = strlen(s) - 1, j = 0; i >= 0; --i, ++j)
	{
		s[i] = c[j];
	}

	printf("String is: %s\n", c);
	printf("String Backwards is: %s\n", s);
	if (strcmp(c, s) == 0) printf("Palindrome\n");
	else printf("Not Palindrome\n");
	return 0;
}
