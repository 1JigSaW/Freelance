#include <cmath>

class Complex {
private:
    double re, im;

public:
    Complex(double x) {
        re = x;
        im = 0;
    }
    Complex(double x, double y) {
        re = x;
        im = y;
    }

    double Re() const {
        return re;
    }
    double Im() const {
        return im;
    }

    Complex operator -(Complex other) const {
        return Complex(re - other.re, im - other.im);
    }
    Complex operator -(double other) const {
        return Complex(re - other, im);
    }

    Complex operator +(Complex other) const {
        return Complex(re + other.re, im + other.im);
    }
    Complex operator +(double other) const {
        return Complex(re + other, im);
    }

    Complex operator *(Complex other) const {
        return Complex(re * other.re - im * other.im,
            re * other.im + im * other.re);
    }
    Complex operator *(double other) const {
        return Complex(re * other, im * other);
    }

    Complex operator /(Complex other) const {
        return (*this * Complex(other.re, -other.im)) /
            (other.re * other.re + other.im * other.im);
    }
    Complex operator /(double other) const {
        return Complex(re / other, im / other);
    }

    double Abs() const {
        return sqrt(re * re + im * im);
    }

    Complex operator +() const {
        return Complex(re, im);
    }

    Complex operator -() const {
        return Complex(-re, -im);
    }

    bool operator ==(Complex other) const {
        return re == other.re && im == other.im;
    }

    bool operator !=(Complex other) const {
        return !(*this == other);
    }
};

Complex operator -(double first, Complex second) {
    return Complex(first) - second;
}

Complex operator +(double first, Complex second) {
    return (second + first);
}

Complex operator *(double first, Complex second) {
    return (second * first);
}

Complex operator /(double first, Complex second) {
    return Complex(first) / second;
}

double Abs(Complex first) {
    return first.abs();
}