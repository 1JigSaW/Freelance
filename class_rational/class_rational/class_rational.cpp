#include <iostream>
#include <numeric>

using namespace std;

class Rational {
private:
    int m = 0;
    int n = 1;

public:
    Rational(const int x, const int y) {
        m = x;
        n = y;
        simplify();
    }

    Rational(const int x) {
        m = x;
        simplify();
    }

    Rational() {}

    Rational& simplify() {
        if (n < 0) {
            n *= -1;
            m *= -1;
        }
        int gcd_m_n = gcd(abs(m), abs(n));
        m /= gcd_m_n;
        n /= gcd_m_n;
        return *this;
    }

    Rational operator+() const {
        return *this;
    }

    Rational operator-() const {
        return Rational(-m, n);
    }

    Rational operator+(const Rational& b) const {
        return Rational(
            m * b.n + b.m * n,
            n * b.n);
    }

    Rational operator-(const Rational& b) const {
        return *this + (-b);
    }

    Rational operator*(const Rational& b) const {
        return Rational(
            m * b.m,
            n * b.n);
    }

    Rational operator/(const Rational& b) const {
        return Rational(
            m * b.n,
            n * b.m);
    }

    Rational& operator+=(const Rational& b) {
        *this = *this + b;
        return *this;
    }

    Rational& operator-=(const Rational& b) {
        *this = *this - b;
        return *this;
    }

    Rational& operator*=(const Rational& b) {
        *this = *this * b;
        return *this;
    }

    Rational& operator/=(const Rational& b) {
        *this = *this / b;
        return *this;
    }

    bool operator==(const Rational& b) const {
        return m == b.m && n == b.n;
    }

    bool operator!=(const Rational& b) const {
        return !(*this == b);
    }

    Rational& operator++() {
        *this += 1;
        return *this;
    }

    Rational operator++(int) {
        Rational result(*this);
        ++(*this);
        return result;
    }

    Rational& operator--() {
        *this -= 1;
        return *this;
    }

    Rational operator--(int) {
        Rational result(*this);
        --(*this);
        return result;
    }

    int Numerator() const {
        return m;
    }

    int Denominator() const {
        return n;
    }
};

Rational operator+(const int a, const Rational& b) {
    return Rational(a) + b;
}

Rational operator-(const int a, const Rational& b) {
    return Rational(a) - b;
}

Rational operator*(const int a, const Rational& b) {
    return Rational(a) * b;
}

Rational operator/(const int a, const Rational& b) {
    return Rational(a) / b;
}

ostream& operator<<(ostream& os, const Rational& a) {
    os << a.numerator();
    if (a.denominator() != 1) {
        os << "/" << a.denominator();
    }
    return os;
}