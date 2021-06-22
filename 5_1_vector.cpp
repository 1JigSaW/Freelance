#include <string>
#include <iosfwd>
template <class T>
class Vector {
public:

	Vector(int size,const T& val);

	Vector(const Vector<T>&);

	Vector(Vector<T>&&);

	~Vector();

	void push_back(const T&);

	const T& operator[](int) const;
	T& operator[](int);

	Vector<T>& operator=(const Vector<T>&);
	Vector<T>& operator=(Vector<T>&&);

	int size() const;
	bool empty() const;
	
	void clear();

	
	std::string toString(unsigned int width=0, char fill=' ') const;

	
	template <class U>
	friend std::ostream& operator<<(std::ostream&, const Vector<U>&);

	
	template <class U>
	friend std::istream& operator>>(std::istream&, Vector<U>&);
private:
	
};