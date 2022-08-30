/*June 2014:
Write a program that solves the following problem. A two-digit number should be loaded. Then it should be loaded
array of three-digit numbers whose dimension is the previously loaded number. Calculate and print how much
elements of the array satisfy the condition that the product of their digits is less than 15. Control should be performed
input and enable multiple execution of the program at the user's request.
*/
#include <stdio.h>

int numberToArray(int numb)	//return array made out of number
{
	int i, temp, array[3], count = 0;
	for (i = 0; i < 3; i++)
	{
		array[i] = numb % 10;
		numb /= 10;
	}

	temp = array[0] *array[1] *array[2];
	if (temp < 15)
		count++;
	return count;
}

main()
{
	char answ;
	do {
		int n, i, counter = 0;
		do {
			printf("Enter a two-digit number: ");
			scanf("%d", &n);
		} while (n > 99 || n < 10);
		int a[n];
		for (i = 0; i < n; i++)
		{
			do {
				printf("Enter %d. a three-digit number: ", i + 1);
				scanf("%d", &a[i]);
			} while (a[i] < 100 || a[i] > 999);
		}

		for (i = 0; i < n; i++)
		{
			if (numberToArray(a[i]) == 1)
				counter++;
		}

		printf("There are %d", counter);
		printf("\n\nDo you want to start the program again? (Y|N): ");
		scanf(" %c", &answ);
	} while (answ == 'Y' || answ == 'y');
}
