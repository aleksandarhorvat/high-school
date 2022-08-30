#include <stdio.h>

main()
{
	FILE * file;
	/*We open the attachment file and check if an error occurred*/
	if ((file = fopen("dat.txt", "a")) == NULL)
	{
		/*An error is reported on the error output*/
		fprintf(stderr, "Greska: nisam uspeo da otvorim dat.txt\n");
		/*The program is ending*/
		return 1;
	}

	/*We write the content to the file*/
	fprintf(file, "Hello everyone\n");
	/*We are closing the file */
	fclose(file);
}
