#include <stdio.h>
#include <ctype.h>

int main()
{
	char c;
	int result;
	c = '\0';
	result = isgraph(c);
	printf("When %c is passed to isgraph() = %d\n", c, isgraph(c));
}
