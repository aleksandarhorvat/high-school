#include <stdio.h>

int main(void)
{
	char s[20];
	FILE *f = fopen("file.txt", "w");
	int i = fputs("12A", f);
	fclose(f);
	f = fopen("file.txt", "r");
	fgets(s, 4, f);
	puts(s);
	fclose(f);
	return 0;
}
