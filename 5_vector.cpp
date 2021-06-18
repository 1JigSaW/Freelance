#include <cstddef>

class Vector {
 private:
    int * ptr_of_array = new int[0];
    size_t capacity, size_of_array;

 public:
    Vector() {
    }
    Vector(const Vector & other) {
        delete [] ptr_of_array;
        capacity = other.capacity;
        size_of_array = other.size_of_array;
        int * ptr_temp = new int[capacity];
        size_t i = 0;
        while (i < size_of_array) {
            ptr_temp[i] = other.ptr_of_array[i];
            i++;
        }
        ptr_of_array = ptr_temp;
    }
    ~Vector() {
        delete[] ptr_of_array;
    }

    Vector & operator = (const Vector & other) {
        delete [] ptr_of_array;
        capacity = other.capacity;
        size_of_array = other.size_of_array;
        int * ptr_temp = new int[capacity];
        size_t i = 0;
        while (i < size_of_array) {
            ptr_temp[i] = other.ptr_of_array[i];
            i++;
        }
        ptr_of_array = ptr_temp;
        return *this;
    }

    void push_back(int && other) {
        if (size_of_array != 0 &&
            size_of_array == capacity) {
            capacity = capacity * 2;
            int * ptr_temp = new int[capacity];
            size_t i = 0;
            while (i < size_of_array) {
                ptr_temp[i] = ptr_of_array[i];
                i++;
            }
            delete [] ptr_of_array;
            ptr_of_array = ptr_temp;
        } else if (size_of_array == 0) {
            capacity = 1;
            delete [] ptr_of_array;
            ptr_of_array = new int[1];
        }
        ptr_of_array[size_of_array] = other;
        size_of_array++;
    }
    void push_back(const int & other) {
        if (size_of_array != 0 &&
            size_of_array == capacity) {
            capacity = capacity * 2;
            int * ptr_temp = new int[capacity];
            size_t i = 0;
            while (i < size_of_array) {
                ptr_temp[i] = ptr_of_array[i];
                i++;
            }
            delete [] ptr_of_array;
            ptr_of_array = ptr_temp;
        } else if (size_of_array == 0) {
            capacity = 1;
            delete [] ptr_of_array;
            ptr_of_array = new int[1];
        }
        ptr_of_array[size_of_array] = other;
        size_of_array++;
    }
    void pop_back() {
        size_of_array = size_of_array - 1;
    }

    const int & operator[](const size_t & x) const {
        return ptr_of_array[x];
    }
    int & operator[] (const size_t & x) {
        return ptr_of_array[x];
    }

    size_t size() {
        return size_of_array;
    }
};