#include <stdio.h>
int main()
{
	int p1[2];
	pipe(p1);

	int a=fork();
	if (a>1)
	{
		int x=20;
		printf("i'm parent \n");
		close (p1[0]);
		write(p1[1],&x,sizeof(x));
	}
	else if(a==0)
	{
		int y;
		printf("i'm child \n");
		close(p1[1]);
		read(p1[0],&y,sizeof(y));
		printf("%d",&y);
	}
	return 0;
}
