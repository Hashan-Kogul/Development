#include <stdio.h>
int main()
{
	printf("Hello \n");
	int a=fork();
	if (a>0)
	{
		printf("I'm parent process,Good morning \n");
	}
	else{
		printf("i'm child process,You are welcome \n");
	return 0;
	}
}	
