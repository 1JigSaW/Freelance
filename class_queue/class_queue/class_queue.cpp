#include <algorithm>
#include <deque>
#include <iterator>
#include <iostream>

template <typename T, typename Container = std::deque<T>>
class Queue {
private:
    Container all_container;

public:
    Queue() {
        Container all_container;
    }


    T front() const {
        return *all_container.begin();
    }
    T& front() {
        return *all_container.begin();
    }


    void pop() {
        all_container.pop_front();
    }

    void push(T temp) {
        all_container.push_back(temp);
    }

    size_t size() {
        return all_container.size();
    }

    bool empty() {
        return all_container.size() == 0;
    }

    bool operator ==(Queue <T> other) {
        auto other_it1 = other.all_container.begin();
        auto other_it2 = other.all_container.end();
        auto it1 = all_container.begin();
        if (all_container.size() == other.all_container.size()) {
            return std::equal(other_it1, other_it2, it1);
        }
        else {
            return false;
        }
    }

    bool operator !=(Queue <T> other) {
        return !(*this == other);
    }
};