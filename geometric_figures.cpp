#include <iostream>

class Figure {
public:
    virtual int Perimeter() const = 0;
};

class Triangle : public Figure{
private:
    double x;
    double y;
    double z;
public:
    Triangle(int _x, int _y, int _z) : x(_x), y(_y), z(_z) {}

    int Perimeter() const override
    {
        return x + y + z;
    }
};

class Rectangle : public Figure {
private:
    double x;
    double y;
public:
    Rectangle(int _x, int _y) : x(_x), y(_y) {}

    int Perimeter() const override
    {
        return (x + y) * 2;
    }
};




