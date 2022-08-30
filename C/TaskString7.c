#include <stdio.h>

main()
{
	int i, j;
	char text[100];
	gets(text);
	for (i = 0, j = 0; text[i] != '\0'; i++) //for each character entered
		if (text[i] != '.')	//if the character is a dot
			text[j++] = text[i]; //write without a dot
	text[j] = '\0';
	puts(text);
}
