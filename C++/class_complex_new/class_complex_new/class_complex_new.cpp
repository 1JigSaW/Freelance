#include <iostream>
#include <cmath>

using namespace std;

class Complex        
{
private:
    double re, im;      

public:

    Complex()
    {
    };

    Complex(double r)
    {
        re = r;
        im = 0;
    }

    Complex(double r, double i)
    {
        re = r;
        im = i;
    }

    Complex(const Complex& c)   
    {
        re = c.re;
        im = c.im;
    }

    ~Complex()
    {
    }

    double abs()
    {
        return sqrt(re * re + im * im);
    }

    Complex& operator = (Complex& c)
    {
        re = c.re;
        im = c.im;

        return (*this);
    }


    Complex& operator += (Complex& c)
    {
        re += c.re;
        im += c.im;
        return *this;
    }

    Complex operator + (const Complex& c)
    {
        return Complex(re + c.re, im + c.im);
    }

    Complex operator - (const Complex& c)
    {
        return Complex(re - c.re, im - c.im);
    }

    Complex operator * (const Complex& c)
    {
        return Complex(re * c.re - im * c.im, re * c.im + im * c.re);
    }

    // оператор деления
    Complex operator / (const Complex& c)
    {
        Complex temp;

        double r = c.re * c.re + c.im * c.im;
        temp.re = (re * c.re + im * c.im) / r;
        temp.im = (im * c.re - re * c.im) / r;

        return temp;
    }

    friend ostream& operator<< (ostream&, const Complex&);
    friend istream& operator>> (istream&, Complex&);

};

ostream& operator<< (ostream& out, const Complex& c)
{
    out << "(" << c.re << ", " << c.im << ")";
    return out;
}

istream& operator>> (istream& in, Complex& c)
{
    in >> c.re >> c.im;
    return in;
}