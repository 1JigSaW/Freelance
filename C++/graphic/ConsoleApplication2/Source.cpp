#include <graphics.h>
#include <stdlib.h>
#include <stdio.h>
#include <iostream>
#include <time.h>
#include <conio.h>  
using namespace std;

void car(int x, int y, int color)
{

    bar(x, y, x + 111, y + 22);
    bar(x + 22, y, x + 70, y - 22);
    setcolor(color); 
    circle(x + 22, y + 33, 10); 
    circle(x + 67, y + 33, 10); 
    setfillstyle(1, color);
    floodfill(x + 22, y + 33, color);
    floodfill(x + 67, y + 33, color);
}

int main(void)
{
    clock_t start = clock(), diff;
    int i; 
    int x; 
    int y; 
    int v;
    x = 50;
    y = 200;
    v = 1;
    initwindow(700, 700);
    for (i = 1; i < 500; i++)
    {
        car(x, y, 2);
        delay(20);
        car(x, y, 0);
        x = x + v;
    }
    car(x, y, 2);
    getch();
    closegraph();

    diff = clock() - start;
    int msec1 = diff * 1000 / CLOCKS_PER_SEC;
    printf("Time taken %d seconds %d milliseconds", msec1 / 1000, msec1 % 1000);
    
	return 0;
}