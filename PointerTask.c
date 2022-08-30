//A program that extracts only letters from a given string.
//The function returns a pointer as a newly created string.
#include <stdio.h>

char *justLetters(char *p);

main()
{
	char *S2;
	char S1[] = "93 Thorne St. Roslindale, MA 02131";
	printf("The initial contents of the array: ");
	printf("%s\n", S1);
	//function call
	S2 = justLetters(S1);
	printf("A string containing only letters: ");
	printf("%s", S2);
}

//letter extraction function
char *justLetters(char *s1pok)
{
	static char a[80], *p;
	p = a;	//p points to the first term of the new string
	while (*s1pok)
	{
		// lowercase or uppercase letter
		if ((*s1pok >= 'a' && *s1pok <= 'z') || (*s1pok >= 'A' && *s1pok <= 'Z'))
		{
			*p = *s1pok;
			p++;
		}

		s1pok++;
	}

	*p = '\0';
	return a;
}
