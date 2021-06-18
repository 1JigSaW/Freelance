#include <algorithm>
#include <utility>

template<typename T>
class SharedPtr {
private:
    T* data = nullptr;
    int* cnt = nullptr;

    void clear() {
        if (cnt != nullptr) {
            --*cnt;
            if (*cnt == 0) {
                delete data;
                delete cnt;
            }
        }
        data = nullptr;
        cnt = nullptr;
    }

public:
    SharedPtr() {}

    SharedPtr(T* temp) : data(temp), cnt(new int(1)) {}

    SharedPtr(const SharedPtr<T>& elem) {
        data = elem.data;
        cnt = elem.cnt;
        ++*cnt;
    }

    SharedPtr(SharedPtr<T>&& other) {
        data = other.data;
        cnt = other.cnt;
        other.data = nullptr;
        other.cnt = nullptr;
    }

    SharedPtr& operator=(const SharedPtr& other) {
        if (data != other.data) {
            this->clear();
            data = other.data;
            cnt = other.cnt;
            ++*cnt;
        }
        return *this;
    }

    SharedPtr& operator=(SharedPtr&& other) {
        if (data != other.data) {
            this->clear();
            data = other.data;
            cnt = other.cnt;
            other.data = nullptr;
            other.cnt = nullptr;
        }
        return *this;
    }

    SharedPtr& operator=(const T* other) {
        if (data != other) {
            this->clear();
            data = other;
            cnt = new int(1);
        }
        return *this;
    }

    const T& operator*() const noexcept { return *data; }
    T& operator*() noexcept { return *data; }
    T* operator->() const noexcept { return data; }
    T* get() const noexcept { return data; }

    void reset(T* ptr) {
        this->clear();
        data = ptr;
        cnt = new int(1);
    }

    void swap(SharedPtr& other) {
        std::swap(data, other.data);
        std::swap(cnt, other.cnt);
    }

    explicit operator bool() const noexcept { return data != nullptr; }
    ~SharedPtr() { this->clear(); }
};