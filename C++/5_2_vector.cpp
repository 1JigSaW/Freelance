#include <bits/stdc++.h>
using namespace std;
template <typename T> class vectorClass
{
 
    T* arr;
    int capacity;
    int current;
 
public:

    vectorClass()
    {
        arr = new T[1];
        capacity = 1;
        current = 0;
    }

    void push(T data)
    {
 
        if (current == capacity) {
            T* temp = new T[2 * capacity];
 
            for (int i = 0; i < capacity; i++) {
                temp[i] = arr[i];
            }
 
            delete[] arr;
            capacity *= 2;
            arr = temp;
        }
 
        arr[current] = data;
        current++;
    }
 
    void push(int data, int index)
    {
 
        if (index == capacity)
            push(data);
        else
            arr[index] = data;
    }
 
    T get(int index)
    {
 
        if (index < current)
            return arr[index];
    }
 
    void pop() { current--; }
 
    int size() { return current; }
 
    int getcapacity() { return capacity; }
 
    void print()
    {
        for (int i = 0; i < current; i++) {
            cout << arr[i] << " ";
        }
        cout << endl;
    }
};