#include <iostream>
#include <stdexcept>

class Date {
private:
    int day, month, year;

public:
    Date(int d, int m, int y) {
        if (y >= 1970 && y <= 2099) {
            if (m >= 1 && m <= 12) {
                if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) {
                    if (d < 1 || d > 31) {
                        throw std::invalid_argument("incorrect date");
                    }
                }
                else if (m == 4 || m == 6 || m == 9 || m == 11) {
                    if (d < 1 || d > 30) {
                        throw std::invalid_argument("incorrect date");
                    }
                }
                else {
                    if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0) {
                        if (d < 1 || d > 29) {
                            throw std::invalid_argument("incorrect date");
                        }
                    }
                    else {
                        if (d < 1 || d > 28) {
                            throw std::invalid_argument("incorrect date");
                        }
                    }
                }
            }
            else {
                throw std::invalid_argument("incorrect month");
            }
        }
        else {
            throw std::invalid_argument("incorrect year");
        }
        day = d;
        month = m;
        year = y;
    }

    int GetDay() const {
        return day;
    }

    int GetMonth() const {
        return month;
    }

    int GetYear() const {
        return year;
    }

    Date& operator ++() {
        if (month == 1 || month == 3 || month == 5 || month == 7 ||
            month == 8 || month == 10 || month == 12) {
            if (day != 31) {
                day++;
            }
            else {
                if (month == 12) {
                    day = 1;
                    month = 1;
                    year++;
                }
                else {
                    day = 1;
                    month++;
                }
            }
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11) {
            if (day != 30) {
                day++;
            }
            else {
                day = 1;
                month++;
            }
        }
        else {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
                if (day != 29) {
                    day++;
                }
                else {
                    day = 1;
                    month++;
                }
            }
            else {
                if (day != 28) {
                    day++;
                }
                else {
                    day = 1;
                    month++;
                }
            }
        }
        return *this;
    }

    Date& operator --() {
        if (month == 2 || month == 4 || month == 6 || month == 8 ||
            month == 9 || month == 11 || month == 1) {
            if (day != 1) {
                day--;
            }
            else {
                if (month == 1) {
                    day = 31;
                    month = 12;
                    year--;
                }
                else {
                    day = 31;
                    month--;
                }
            }
        }
        else if (month == 5 || month == 7 || month == 10 || month == 12) {
            if (day != 1) {
                day--;
            }
            else {
                day = 30;
                month--;
            }
        }
        else {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
                if (day != 1) {
                    day--;
                }
                else {
                    day = 29;
                    month--;
                }
            }
            else {
                if (day != 1) {
                    day--;
                }
                else {
                    day = 28;
                    month--;
                }
            }
        }
        return *this;
    }

    Date operator +(const int& other) {
        for (int i = 0; i < other; i++) {
            ++(*this);
        }
        return *this;
    }

    Date operator -(const int& other) {
        for (int i = 0; i < other; i++) {
            --(*this);
        }
        return *this;
    }

    int operator -(const Date& other) {
        int ans;
        int part_1 = 0, part_2 = 0;

        for (int i = 1970; i <= year - 1; i++) {
            if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0) {
                part_1 += 366;
            }
            else {
                part_1 += 365;
            }
        }
        for (size_t i = 1; i <= month - 1; i++) {
            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12) {
                part_1 += 31;
            }
            else if (i == 4 || i == 6 || i == 9 || i == 11) {
                part_1 += 30;
            }
            else {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
                    part_1 += 29;
                }
                else {
                    part_1 += 28;
                }
            }
        }
        part_1 += day;
        for (int i = 1970; i <= other.year - 1; i++) {
            if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0) {
                part_2 += 366;
            }
            else {
                part_2 += 365;
            }
        }
        for (int i = 1; i <= other.month - 1; i++) {
            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12) {
                part_2 += 31;
            }
            else if (i == 4 || i == 6 || i == 9 || i == 11) {
                part_2 += 30;
            }
            else {
                if ((other.year % 4 == 0 && other.year % 100 != 0) || other.year % 400 == 0) {
                    part_2 += 29;
                }
                else {
                    part_2 += 28;
                }
            }
        }
        part_2 += other.day;
        ans = part_1 - part_2;
        return ans;
    }
};
