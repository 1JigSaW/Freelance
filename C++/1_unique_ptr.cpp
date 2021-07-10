#include <utility>

template <typename T>
class UniquePtr {
 private:
    T * ptr = nullptr;

 public:
    UniquePtr() {
        ptr = nullptr;
    }
    UniquePtr(T * other) {
        ptr = other;
        other = nullptr;
    }
    UniquePtr(UniquePtr && other) {
        ptr = other.ptr;
        other.ptr = nullptr;
    }

    UniquePtr & operator = (UniquePtr &&other) {
        delete ptr;
        ptr = other.ptr;
        other.ptr = nullptr;
        return *this;
    }
    UniquePtr operator = (UniquePtr & other) = delete;

    ~UniquePtr() {
        delete ptr;
    }

    T & operator * () const {
        return *ptr;
    }

    T * operator -> () const {
        return ptr;
    }

    T * release() {
        T * temp = ptr;
        ptr = nullptr;
        return temp;
    }

    void reset(T * other) {
        delete ptr;
        ptr = other;
    }

    void swap(UniquePtr& other) {
        std::swap(ptr, other.ptr);
    }

    T * get() const {
        return ptr;
    }

    explicit operator bool() const {
        if (ptr != nullptr) {
            return true;
        }
        return false;
    }

    UniquePtr(UniquePtr &other) = delete;
};