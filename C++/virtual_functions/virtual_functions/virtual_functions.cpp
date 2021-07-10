// virtual_functions.cpp 
//

#include <iostream>


class Array
{
public:
    static const size_t max_size = 100;
    int data[max_size];
    size_t size;
    Array() : size(0) { }
    Array(size_t _size, int value = 0) :size(_size)
    {
        if (_size > max_size)
        {
            std::cout << "Size is bigger than max_size\n";
            exit(1);
        }
        for (int i = 0; i < size; i++)
        {
            this->data[i] = value;
        }
    }
    void print()
    {
        for (size_t i = 0; i < size; i++)
        {
            std::cout << data[i];
        }
        
    }


    virtual void slozhenie(const Array& y) {
        int k = 0;
        for (int i = 0; i < size; i++) {
            data[i] = data[i] + y.data[i] - '0' + k;
            k = 0;
            if (data[i] > '9') {
                k++;
                data[i] = data[i] - 10;
            }
        }
        if (k == 1) data[size] = '1';
    }
};



class Fraction : public Array
{
private:
    int sign_;
    float num;
    float den;

public:
    Fraction(float top, float bottom, int sign) {
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

    void print()
    {
        for (size_t i = 0; i < size; i++)
        {
            std::cout << data[i];
        }

    }

    virtual void slozhenie(const Array& y) override {
        int k = 0;
        for (int i = 0; i < size; i++) {
            data[i] = data[i] + y.data[i] - '0' + k;
            k = 0;
            if (data[i] > '9') {
                k++;
                data[i] = data[i] - 10;
            }
        }
        if (k == 1) data[size] = '1';
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

    virtual void slozhenie(const Array& y) override {
        int k = 0;
        for (int i = 0; i < size; i++) {
            data[i] = data[i] + y.data[i] - '0' + k;
            k = 0;
            if (data[i] > '9') {
                k++;
                data[i] = data[i] - 10;
            }
        }
        if (k == 1) data[size] = '1';
    }

    void print()
    {
        for (size_t i = 0; i < size; i++)
        {
            std::cout << data[i];
        }

    }
};

int main()
{
    Array rray(10, 2);
    rray.print();
    rray.slozhenie(23);
    std::cout << std::endl;
    rray.print();
    
}