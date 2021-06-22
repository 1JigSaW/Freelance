template <typename T>
class vector {
public:
   vector(int _DEFAULT_VECTOR_SIZE = 10) :
       size(0), array_(new T[_DEFAULT_VECTOR_SIZE]), capacity(_DEFAULT_VECTOR_SIZE)  {}
  void push_back(T& elem)
  {
    if (size == capacity)
    resize(2 * size);
    array_[size] = elem;
    size++;
  }

  void pop_back()
  {
     --size;
  }

  void resize(int size_)
  {
     if (size_ > capacity)
    {
      T* temp = new T[size_];
      memcpy(temp,array_,size*sizeof(T));
      swap(temp, array_);
      delete[] array_; 
      capacity = size_;
     }
  }

  private:
    T* array_; 
    int size;
    int capacity;
 };