#include <algorithm>
using namespace std;

class Node {
private:
    Node* prev;
    int value;
    Node* next;

public:
    Node(Node* prev_, Node* next_, int value_) : prev(prev_), next(next_), value(value_) {}

    Node() : prev(this), next(this) {}

    void newPrev(Node* temp) { prev = temp; }
    void newNext(Node* temp) { next = temp; }

    Node* getPrev() { return prev; }
    Node* getNext() { return next; }

    int getValue() const { return value; }
    int& getValue() { return value; }
};

class ListIterator {
private:
    Node* now;

public:
    ListIterator(Node* temp) : now(temp) {}

    ListIterator& operator++() {
        now = now->getNext();
        return *this;
    }

    ListIterator& operator--() {
        now = now->getPrev();
        return *this;
    }

    ListIterator operator++(int) {
        ListIterator temp(now);
        now = now->getNext();
        return temp;
    }

    ListIterator operator--(int) {
        ListIterator temp(now);
        now = now->getPrev();
        return temp;
    }

    int operator*() const { return now->getValue(); }
    int& operator*() { return now->getValue(); }

    const Node* getAddress() const { return now; }
};

bool operator==(const ListIterator& one, const ListIterator& two) {
    return (one.getAddress() == two.getAddress());
}

bool operator!=(const ListIterator& one, const ListIterator& two) {
    return !(one == two);
}

class List {
private:
    Node* main;
    size_t sz;

    void Clear() {
        Node* now = main->getNext();
        while (now != main) {
            Node* next = now->getNext();
            delete now;
            swap(now, next);
        }
        sz = 0;
    }

public:
    List() : sz(0) { main = new Node(); }

    void push_front(int num) {
        Node* temp = main->getNext();
        Node* data = new Node(main, temp, num);
        temp->newPrev(data);
        main->newNext(data);
        ++sz;
    }

    void push_back(int num) {
        Node* temp = main->getPrev();
        Node* data = new Node(temp, main, num);
        temp->newNext(data);
        main->newPrev(data);
        ++sz;
    }

    void pop_front() {
        Node* pop = main->getNext();
        Node* newFront = pop->getNext();
        newFront->newPrev(main);
        main->newNext(newFront);
        delete pop;
        --sz;
    }

    void pop_back() {
        Node* pop = main->getPrev();
        Node* newFront = pop->getPrev();
        newFront->newNext(main);
        main->newPrev(newFront);
        delete pop;
        --sz;
    }

    size_t size() const { return sz; }

    ListIterator begin() { return ListIterator(main->getNext()); }
    ListIterator end() { return ListIterator(main); }
    ListIterator begin() const { return ListIterator(main->getNext()); }
    ListIterator end() const { return ListIterator(main); }

    List& operator=(const List& other) {
        this->Clear();
        auto it = other.begin();
        while (it != other.end()) {
            this->push_front(*it++);
        }
        sz = other.sz;
        return *this;
    }

    ~List() {
        this->Clear();
        delete main;
    }
};