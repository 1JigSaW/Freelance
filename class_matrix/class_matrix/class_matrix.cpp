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