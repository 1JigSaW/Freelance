// Distribute_The_Spaces.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include  <stdio.h>
#include <locale.h>
#include <string.h>

int main(int argc, char* argv[]) {
    setlocale(LC_ALL, ""); // русский язык
    char str[101] = ""; // объявил переменную
    char res[101] = ""; // объявил переменную

    printf("Введите строку символов:");
    fgets(str, 101, stdin); // ввод строки


    int j = 0;
    int i;
    for (i = 0; i < strlen(str); i++) { // цикл в длину строки
        if (str[i] == ' ') // если встречается пробел
        {
            if (j == 0) continue; // если это первый пробел - пропуск
            if (str[i + 1] == ' ') continue; // если после пробела опять пробел - пропуск
        }
        res[j] = str[i]; // присваивание значения строки
        j++; // счетчик символов
    }
    i = strlen(res); // i - длина новой строки
    if (res[i - 2] == ' ') // последний пробел
        res[i - 2] = '\0';

    printf("\nОтвет:%s", res);
    getchar();
}
