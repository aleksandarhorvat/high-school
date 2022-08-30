/*June 2012:
The program should read a five-digit natural number N. Input control should be performed. From the loaded number
N, the sequence L should be generated in the following way: each element of the sequence will receive the value of the minimum digit
number N, and the array will have as many elements as the value of the maximum digit of number N.
Example: N=24873; L=[2,2,2,2,2,2,2,2]. Multiple execution of the program should be enabled.
*/
#include <stdio.h>

main()
{
	char answ;
	do {
		int n[5], i, place, digit;
		again:
			for (i = 0; i < 5; i++)
			{
				printf("Enter %d. digit of five-digit number: ", i + 1);
				scanf("%d", &n[i]);
				if (n[i] >= 10 || n[i] < 0)
				{
					printf("You did not enter a digit, but a number, enter again!\n\n");
					goto again;
				}
			}

		place = n[0];
		digit = n[0];
		for (i = 0; i < 5; i++)
		{
			if (n[i] < digit)
				digit = n[i];
			if (n[i] > place)
				place = n[i];
		}

		int l[place];
		for (i = 0; i < place; i++)
		{
			l[i] = digit;
			printf("\n%d.digit of array L is %d", i + 1, l[i]);
		}

		printf("\n\nDo you want to start the program again? (Y|N): ");
		scanf(" %c", &answ);
	} while (answ == 'Y' || answ == 'y');
}
