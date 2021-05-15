#include <iostream>
#include <vector>

using namespace std;

template <typename T>
class Matrix {
private:
    vector <vector <T>> matr;

public:
    Matrix(const std::vector<std::vector<T>>& input) {
        matr = input;
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