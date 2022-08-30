#include <stdio.h>
#include <stdlib.h>
#include <time.h>

main()
{
	char answ;
	int number, guessed;
	srand(time(NULL));
	do {
		number = rand() % 11;
		printf("Guess the number from 0 to 10: ");
		scanf("%d", &guessed);
		if (guessed == number)
		{
			printf("Well done, you guessed it!");
			break;
		}
		else
		{
			printf("You didn't guess the number, the number was %d\n", number);
		}

		printf("Do you want to try again? (Y/N): ");
		scanf(" %c", &answ);
	}

	while (answ == 'Y' || answ == 'y');
}
