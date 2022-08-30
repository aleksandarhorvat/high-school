/*June 2013:
At the beginning, the program should read a natural number N>100. Input control should be performed. From loaded
number N, array L should be generated in the following way: each element of the array will receive the value of another digit
number N, and the array will have as many elements as the value of the first digit of number N.
Example: N=24873; L=[4,4]. Multiple execution of the program should be enabled
*/
#include <stdio.h>

int numberOfDigits(int number)	//how many digits number have
{
	int i, count;
	while (number != 0)
	{
		number /= 10;
		count++;
	}

	return count;
}

int *numberToArray(int *array, int numb, int size)	//return array made out of number
{
	int i;
	for (i = size - 1; i >= 0; i--)
	{
		array[i] = numb % 10;
		numb /= 10;
	}

	return array;
}

main()
{
	char answ;
	do {
		int n, i, size;
		do {
			printf("Enter a number, so that it is greater than 100: ");
			scanf("%d", &n);
		} while (n < 100);
		size = numberOfDigits(n);
		int a[size];
		int *p = numberToArray(a, n, size);
		int l[p[0]];
		for (i = 0; i < p[0]; i++)
		{
			l[i] = p[1];
			printf("\n%d. digit of array is: %d", i + 1, l[i]);
		}

		printf("\n\nDo you want to start the program again? (Y|N): ");
		scanf(" %c", &answ);
	} while (answ == 'Y' || answ == 'y');
}
