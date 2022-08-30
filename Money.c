#include <stdio.h>

main()
{
	int N5, N10, N20, price, total;
	printf("Enter the price of the product: ");
	scanf("%d", &price);
	printf("Enter how many 5 dinar coins you have: ");
	scanf("%d", &N5);
	printf("Enter how many 10 dinar coins you have: ");
	scanf("%d", &N10);
	printf("Enter how many 20 dinar coins you have: ");
	scanf("%d", &N20);
	total = (N5 *5) + (N10 *10) + (N20 *20);
	if (total - price > 0)
		printf("You have %d dinars, which is enough money for shopping, and your change is %d", total, total - price);
	else
		printf("You have %d dinars, which is not enough, you are missing %d", total, price - total);
}
