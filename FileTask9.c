#include <stdio.h>

int main(void)
{
	FILE *f = fopen("file.txt", "w");
	fseek(f, 3, SEEK_END);
	return 0;
}
