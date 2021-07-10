#include <iostream>

using namespace std;



template <class T>
class myList {

    
    
    struct node {
     
        T data;
        node* next;
        
        
        
        node(T obj) 
            : data(obj), 
            next(NULL) 
            {}
           

 
        ~node() {
        
            // cout << "Destructor of node with data: " << data << endl;
            
            if (this->next)
                delete this->next;
        }
        
        
        
        void print(ostream& os) {
            
            os << this->data << endl;
            
            if (this->next)
                this->next->print(os);
        }
    };
    
    
    
    node* first;
    node* last;
    unsigned int count;
    
public:

    
    
    struct iterator
    {
        node *curr;
        
        
        
        iterator() : curr(NULL) 
        {}
        
        
        
        bool isValid()
        {
            return curr != NULL;
        }
        
        
        
        void operator++ ()
        {
            if (curr)
                curr = curr->next;
        }
        
        
        
        T* operator-> ()
        {
            if (curr)
                return &(curr->data);
            else
                throw ("myList: Invalid iterator!");
        }
        
        
        
        T& operator* ()
        {
            if (curr)
                return curr->data;
            else
                throw ("myList: Invalid iterator!");
        }
        
    };
    
    

    myList();
    ~myList();
    bool empty();
    unsigned int getCount();
    T* insert(T& obj);   
    void print(ostream& os);
    T* exists(T& obj);
    iterator begin();
};



template <class T>
myList<T>::myList() {
    
    this->first = this->last = NULL;
    count = 0;
}



template <class T>
myList<T>::~myList() {
 
    if (this->first)
        delete this->first;
}



template <class T>
bool myList<T>::empty()
{
    return count == 0;
}



template <class T>
unsigned int myList<T>::getCount()
{
    return count;
}



template <class T>
T* myList<T>::insert(T& obj) {
    
    // If list is empty
    if (this->first == NULL) 
        this->first = this->last = new node(obj);
    
    // If list is not empty
    else 
        this->last = this->last->next = new node(obj);
    
    count++;
    return &(this->last->data);
}



template <class T>
void myList<T>::print(ostream& os) {
    
    if (this->first != NULL)
        this->first->print(os);
}



template <class T>
inline ostream& operator << (ostream& os, myList<T> &l) 
{
    l.print(os);
    return os;
}



template <class T>
T* myList<T>::exists(T& obj) {
    
    node* curr = this->first;
    
    while(curr) {
        
        if (curr->data == obj)
            return &(curr->data);
            
        curr = curr->next;
    }
    
    return &(curr->data);
}



template <class T>
typename myList<T>::iterator myList<T>::begin()
{
    iterator it;
    it.curr = first;
    return it;
}