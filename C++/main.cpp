#include <graphics.h>
#include <conio.h>
#include <stdlib.h>
#include <stdio.h>

int main(void)
{
	int driver, mode, errorcode;
	register int i;
	driver = DETECT;
	initgraph(&driver, &mode, "");
	errorcode = graphresult();
	if (errorcode != grOk)
	{
		printf("Oshibka:%s\n", grapherrormsg(errorcode));
		printf("Sadsadsadf\n");
		getch();
		exit(1);
	}

	setcolor(RED);
	bar(50, 50, 300, 300);
	restorecrtmode();
	return 0;
}
