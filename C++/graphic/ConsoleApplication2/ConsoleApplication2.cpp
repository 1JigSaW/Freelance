#include <windows.h>
#include<stdio.h>
#include<conio.h>
#include<graphics.h>
void main()
{
    HWND hwnd;
    char Title[1024];
    int iWidth = GetSystemMetrics(SM_CXSCREEN);  // разрешение экрана по горизонтали
    int iHeight = GetSystemMetrics(SM_CYSCREEN); // разрешение экрана по вертикали
    GetConsoleTitle(Title, 1024); // Узнаем имя окна
    // или GetModuleFileName(NULL,Title, sizeof(Title));

    hwnd = FindWindow(NULL, Title); // Узнаем hwnd окна
    HDC hdc = GetDC(hwnd);    // Получаем контекст для рисования
    HPEN p1, p2 = CreatePen(PS_SOLID, 2, RGB(255, 0, 0)); // Создаем красное перо
    p1 = (HPEN)SelectObject(hdc, p2);  // Заносим красное перо в контекст рисования
    int x = -10;
    MoveToEx(hdc, x, x * x, NULL);
    do
    {
        int y = x * x;
        LineTo(hdc, x * 50 + getmaxx() / 2, getmaxy() / 2 - (y * 20));
        x = x + 0.02;
    } while (x < 10);
    SelectObject(hdc, p1);   // Возвращаем старое перо
    ReleaseDC(hwnd, hdc);    // Освобождаем контекст рисования
    DeleteObject(p2);       // Удаляем созданное перо
    _getch();

}