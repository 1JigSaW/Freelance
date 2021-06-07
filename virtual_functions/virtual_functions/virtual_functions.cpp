// virtual_functions.cpp 
//

#include <iostream>

class Array
{
public:
    static const int s = 15;
    unsigned char a[s];
    int element;

    Array(unsigned char* s, int f = 0) {
        element = f;
        for (int i = 0; i < f; i++) {
            a[i] = s[i];
        }
    };
    Array() = default;

    unsigned char operator [] (int d) {
        if (d >= element || d < 0) {
            std::cout << "error";
            return 0;
        }
        return a[d];
    }
    virtual void summ(const Array& y) {
        int k = 0;
        for (int i = 0; i < element; i++) {
            a[i] = a[i] + y.a[i] - '0' + k;
            k = 0;
            if (a[i] > '9') {
                k++;
                a[i] = a[i] - 10;
            }
        }
        if (k == 1) a[element] = '1';
    }
};

class Fraction : public Array
{
private:
    int sign;
    float num;
    float den;

public:
    Fraction(float top, float bottom, int sign_) {
        sign_ = sign;
        num = top;
        den = bottom;
    }
    Fraction(float n, float d) {
        if (d == 0) {
            std::cout << "Denominator may not be 0." << std::endl;
            exit(0);
        }
        else if (n == 0) {
            num = 0;
            den = 1;
        }
        else {
            int sign = 1;
            if (n < 0) {
                sign *= -1;
                n *= -1;
            }
            if (d < 0) {
                sign *= -1;
                d *= -1;
            }

        }
    }

    virtual void summ(const Array& y) override {
        int k = 0;
        for (int i = 0; i < element; i++) {
            a[i] = a[i] + y.a[i] - '0' + k;
            k = 0;
            if (a[i] > '9') {
                k++;
                a[i] = a[i] - 10;
            }
        }
        if (k == 1) a[element] = '1';
    }


};

class String : public Array
{
public:
    char* str[]; 
    String() 
    {
        std::cout << "str" << std::endl;
        *str = new char[10];
    }

    String(const char* str) 
    {
        str = new char[1];
    }

    virtual void summ(const Array& y) override {
        int k = 0;
        for (int i = 0; i < element; i++) {
            a[i] = a[i] + y.a[i] - '0' + k;
            k = 0;
            if (a[i] > '9') {
                k++;
                a[i] = a[i] - 10;
            }
        }
        if (k == 1) a[element] = '1';
    }
};

