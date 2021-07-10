#include <algorithm>
#include <cstddef>
#include <memory>
#include <utility>

template<typename T>
class RawMemory {
public:
    T* buf = nullptr;
    size_t cp = 0;

    static T* Allocate(size_t n) { return static_cast<T*>(operator new(n * sizeof(T))); }
    static void Deallocate(T* buf) { operator delete(buf); }

    RawMemory() = default;
    RawMemory(size_t n) {
        buf = Allocate(n);
        cp = n;
    }
    RawMemory(RawMemory&& other) { Swap(other); }
    RawMemory(const RawMemory&) = delete;

    RawMemory& operator=(const RawMemory&) = delete;
    RawMemory& operator=(RawMemory&& other) noexcept {
        Swap(other);
        return *this;
    }

    T* operator+(size_t i) { return buf + i; }
    const T* operator+(size_t i) const { return buf + i; }
    T& operator[](size_t i) { return buf[i]; }
    const T& operator[](size_t i) const { return buf[i]; }

    void Swap(RawMemory& other) noexcept {
        std::swap(buf, other.buf);
        std::swap(cp, other.cp);
    }

    ~RawMemory() { Deallocate(buf); }
};

template<typename T>
class Vector {
private:
    RawMemory<T> data;
    size_t sz = 0;

public:
    Vector() = default;
    Vector(size_t n) : data(n) {
        std::uninitialized_value_construct_n(data.buf, n);
        sz = n;
    }
    Vector(const Vector& other) : data(other.sz) {
        std::uninitialized_copy_n(other.data.buf, other.sz, data.buf);
        sz = other.sz;
    }
    Vector(Vector&& other) noexcept { swap(other); }

    Vector& operator=(Vector&& other) noexcept {
        swap(other);
        return *this;
    }
    Vector& operator=(const Vector& other) {
        if (other.sz > data.cp) {
            Vector tmp(other);
            swap(tmp);
        } else {
            for (size_t i = 0; i < sz && i < other.sz; ++i) {
                data[i] = other.data[i];
            }
            if (sz < other.sz) {
                std::uninitialized_copy_n(other.data.buf + sz, other.sz - sz, data.buf);
            } else if (sz > other.sz) {
                std::destroy_n(data.buf + other.sz, sz - other.sz);
            }
            sz = other.sz;
        }
        return *this;
    }

    void swap(Vector& other) noexcept {
        data.Swap(other.data);
        std::swap(sz, other.sz);
    }

    void reserve(size_t n) {
        if (n > data.cp) {
            RawMemory<T> temp(n);
            std::uninitialized_move_n(data.buf, sz, temp.buf);
            std::destroy_n(data.buf, sz);
            data = std::move(temp);
        }
    }

    void resize(size_t n) {
        reserve(n);
        if (sz < n) {
            std::uninitialized_value_construct_n(data + sz, n - sz);
        } else if (sz > n) {
            std::destroy_n(data + n, sz - n);
        }
        sz = n;
    }

    void clear() { resize(0); }

    void push_back(const T& num) {
        if (sz == data.cp) {
            reserve(sz == 0 ? 1 : sz * 2);
        }
        new (data + sz) T(num);
        ++sz;
    }

    void push_back(const T&& num) {
        if (sz == data.cp) {
            reserve(sz == 0 ? 1 : sz * 2);
        }
        new (data + sz) T(std::move(num));
        ++sz;
    }

    void pop_back() {
        std::destroy_at(data + sz - 1);
        --sz;
    }

    T* begin() { return data.buf; }
    T* begin() const { return data.buf; }
    T* end() { return (data.buf + sz); }
    T* end() const { return (data.buf + sz); }

    size_t size() const { return sz; }
    size_t capacity() const { return data.cp; }
    const T& operator[](size_t i) const { return data[i]; }
    T& operator[](size_t i) { return data[i]; }

    ~Vector() { std::destroy_n(data.buf, sz); }
};