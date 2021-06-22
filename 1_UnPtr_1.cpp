#include <functional>
#include <iostream>
struct deleteT {
	template <typename T> void operator()(T* t) const { delete t; }
};

template <typename T, typename D> class Unique_Pointer;
template <typename T, typename D>
void swap(Unique_Pointer<T, D>& lhs, Unique_Pointer<T, D>& rhs) {
	using std::swap;
	swap(lhs.ptr, rhs.ptr);
	swap(lhs.deleter, rhs.deleter);
}

template <typename T, typename D = deleteT> class Unique_Pointer {
	friend void swap<T, D>(Unique_Pointer<T, D>&, Unique_Pointer<T, D>&);
public:
	typedef T element_type;
	typedef D deleter_type;
	Unique_Pointer() = default;
	explicit Unique_Pointer(T* t)
	    : ptr(t) {}
	Unique_Pointer(const Unique_Pointer& rhs) = delete;
	Unique_Pointer(Unique_Pointer&& rhs) noexcept
	    : ptr(rhs.ptr)
	    , deleter(std::move(rhs.deleter)) {
		rhs.ptr = nullptr;
	}
	Unique_Pointer& operator=(Unique_Pointer&& rhs) noexcept {
		if (&rhs != this) {
			std::cout << &rhs << "   " << this << std::endl;
			deleter(ptr);
			ptr = nullptr;
			swap(rhs);
		}
		return *this;
	}
	Unique_Pointer& operator=(std::nullptr_t n) noexcept {
		deleter(ptr);
		ptr = nullptr;
		return *this;
	}

	explicit operator bool() const { return ptr ? true : false; }
	T& operator*() const { return *ptr; }
	T* operator->() const { return &*ptr; }

	T* get() const { return ptr; }
	void swap(Unique_Pointer<T, D>& rhs) { ::swap(*this, rhs); }
	void reset() {
		deleter(ptr);
		ptr = nullptr;
	}
	void reset(T* t) {
		if (t != ptr) {
			deleter(ptr);
			ptr = t;
		}
	}
	void reset(T* t, const std::function<void(T*)>& d) {
		reset(t);
		deleter = d;
	}
	T* release() {
		T* ret = ptr;
		ptr = nullptr;
		return ret;
	}
	~Unique_Pointer() { deleter(ptr); }

private:
	T* ptr;
	deleter_type deleter;
};
