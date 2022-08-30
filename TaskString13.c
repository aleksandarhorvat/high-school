#include <stdio.h>

main()
{
	char a[30];
	int i;
	printf("Alphabet: ");
	for (i = 0; i < 26; i++) //for the first 26 characters
		a[i] = 'a' + i;	//add one to 'a'
	a[26] = '\0'; //when you reach 26 characters, put the end of the string
	puts(a);
}
