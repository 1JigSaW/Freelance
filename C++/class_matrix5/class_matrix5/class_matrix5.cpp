#include <iostream>
#include <vector>

using namespace std;

template <typename T>
class Matrix;

template <typename T>
class MatrixIterator {
private:
    Matrix<T>& matr;
    size_t row;
    size_t column;

public:
    MatrixIterator(
        Matrix<T>& m,
        size_t i,
        size_t j) : matr(m), row(i), column(j) {}

    bool operator ==(MatrixIterator other) const {
        return row == other.row && column == other.column;
    }

    bool operator !=(MatrixIterator other) const {
        return !(*this == other);
    }

    T& operator *() {
        return matr[row][column];
    }

    MatrixIterator& operator++ () {
        ++column;
        if (column == matr.size().second) {
            ++row;
            column = 0;
        }
        return *this;
    }

    MatrixIterator operator++ (int) {
        auto tmp = *this;
        ++* this;
        return tmp;
    }
};

template <typename T>
class ConstMatrixIterator {
private:
    const Matrix<T>& matr;
    size_t row;
    size_t column;

public:
    ConstMatrixIterator(
        const Matrix<T>& m,
        size_t i,
        size_t j) : matr(m), row(i), column(j) {}

    bool operator ==(ConstMatrixIterator other) const {
        return row == other.row && column == other.column;
    }

    bool operator !=(ConstMatrixIterator other) const {
        return !(*this == other);
    }

    const T& operator *() const {
        return matr[row][column];
    }

    ConstMatrixIterator& operator++ () {
        ++column;
        if (column == matr.size().second) {
            ++row;
            column = 0;
        }
        return *this;
    }

    ConstMatrixIterator operator++ (int) {
        auto tmp = *this;
        ++* this;
        return tmp;
    }
};

template <typename T>
class Matrix {
private:
    vector <vector <T>> matr;

public:
    Matrix(const std::vector<std::vector<T>>& input) {
        matr = input;
    }

    MatrixIterator <T> begin() {
        return { *this, 0, 0 };
    }
    MatrixIterator <T> end() {
        return { *this, matr.size(), 0 };
    }

    const ConstMatrixIterator <T> begin() const {
        return { *this, 0, 0 };
    }
    const ConstMatrixIterator <T> end() const {
        return { *this, matr.size(), 0 };
    }

    pair<size_t, size_t> size() const {
        return make_pair(matr.size(), matr[0].size());
    }

    const vector <T>& operator[](size_t temp) const {
        return matr[temp];
    }
    vector <T>& operator[](size_t temp) {
        return matr[temp];
    }

    const Matrix& operator +=(const Matrix& other) {
        for (size_t i = 0; i < matr.size(); i++) {
            for (size_t j = 0; j < matr[0].size(); j++) {
                matr[i][j] += other[i][j];
            }
        }
        return *this;
    }

    Matrix operator +(const Matrix& other) const {
        Matrix ans = matr;
        ans += other;
        return ans;
    }

    const Matrix& operator *=(const T& other) {
        for (size_t i = 0; i < matr.size(); i++) {
            for (size_t j = 0; j < matr[0].size(); j++) {
                matr[i][j] *= other;
            }
        }
        return *this;
    }

    Matrix operator *(const T& other) const {
        Matrix ans = matr;
        ans *= other;
        return ans;
    }

    Matrix& transpose() {
        vector <vector<T>> ans;
        for (size_t j = 0; j < matr[0].size(); j++) {
            vector <T> temp;
            for (size_t i = 0; i < matr.size(); i++) {
                temp.push_back(matr[i][j]);
            }
            ans.push_back(temp);
        }
        *this = Matrix(ans);
        return *this;
    }

    Matrix transposed() const {
        vector <vector<T>> ans;
        for (size_t j = 0; j < matr[0].size(); j++) {
            vector <T> temp;
            for (size_t i = 0; i < matr.size(); i++) {
                temp.push_back(matr[i][j]);
            }
            ans.push_back(temp);
        }
        return Matrix(ans);
    }

    Matrix& operator *=(const Matrix& other) {
        assert(matr[0].size() == other.size().first);
        vector <vector <T>> ans;
        for (size_t i = 0; i < matr.size(); i++) {
            vector <T> temp;
            for (size_t j = 0; j < other.size().second; j++) {
                T local = matr[i][0] * other[0][j];
                for (size_t k = 1; k < matr[0].size(); k++) {
                    local += matr[i][k] * other[k][j];
                }
                temp.push_back(local);
            }
            ans.push_back(temp);
        }
        *this = Matrix(ans);
        return *this;
    }

    Matrix operator *(const Matrix& other) const {
        assert(matr[0].size() == other.size().first);
        vector <vector <T>> ans;
        for (size_t i = 0; i < matr.size(); i++) {
            vector <T> temp;
            for (size_t j = 0; j < other.size().second; j++) {
                T local = matr[i][0] * other[0][j];
                for (size_t k = 1; k < matr[0].size(); k++) {
                    local += matr[i][k] * other[k][j];
                }
                temp.push_back(local);
            }
            ans.push_back(temp);
        }
        return Matrix(ans);
    }
};

template <typename T>
std::ostream& operator << (std::ostream& out, const Matrix<T>& m) {
    for (size_t i = 0; i < m.size().first; i++) {
        for (size_t j = 0; j < m.size().second; j++) {
            if (j + 1 != m.size().second) {
                out << m[i][j] << "\t";
            }
            else if (j + 1 == m.size().second && i + 1 != m.size().first) {
                out << m[i][j] << "\n";
            }
            else {
                out << m[i][j];
            }
        }
    }
    return out;
}