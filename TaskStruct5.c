#include <stdio.h>

struct student
{
	int matnumb;
	char lastName[20];
	char name[20];
};
main()
{
	struct student students[30];
	(students + 4)->matnumb = 21375;
	printf("%d", students[4].matnumb);
}
