#include <stdlib.h>
#include <assert.h>

template <class type>
class mylist
{
public:
	mylist()
	:_front(NULL), _back(NULL), num_nodes(0) {
	}
	mylist(int n)
	:_front(NULL), _back(NULL), num_nodes(0)  {
		resize(n);
	}
	mylist(int n, const type& t)
	:_front(NULL), _back(NULL), num_nodes(0)  {
		resize(n,t);
	}
	mylist(const mylist<type>& l)
	:_front(NULL), _back(NULL), num_nodes(0)  {
		*this = l;
	}

	virtual ~mylist() {
		clear();
	}

	bool empty() const {
		return (num_nodes == 0);
	}
	void clear() {
		type_node* temp=_front, *next;
		while(temp)
		{
			next = temp->next;
			delete temp;
			temp = next;
		}
		_front = NULL;
		_back = NULL;
		num_nodes = 0;
	}


	int size() const { 
		return num_nodes;
	}
	void resize(int n) {
		int dest=n;
		n = n-num_nodes;
		if(n<0) {		//resize smaller
			while(n++)
				pop_back();
		}
		else {		//resize bigger
			while(n--)
				push_back();
		}
		assert(num_nodes == dest);
	}
	void resize(int n, const type& t) {
		int dest=n;
		n = n-num_nodes;
		if(n<0) {		//resize smaller
			while(n++)
				pop_back();
		}
		else {		//resize bigger
			while(n--)
				push_back(t);
		}
		assert(num_nodes == dest);
	}

	void append(mylist<type>& l) {
		_back->next = l._front;
		_back->next->prev = _back;
		_back = l._back;
		num_nodes = num_nodes + l.num_nodes;
		l._back = NULL;
		l._front = NULL;
		l.clear();
	}

	void push_back() {
		type_node* temp=new type_node;
		temp->prev = _back;
		temp->next = NULL;
		if(!_back)
			_front = temp;
		else
			_back->next = temp;
		_back = temp;
		num_nodes++;
	}
	void push_back(const type& t) {
		type_node* temp=new type_node;
		temp->t = t;
		temp->prev = _back;
		temp->next = NULL;
		if(!_back)
			_front = temp;
		else
			_back->next = temp;
		_back = temp;
		num_nodes++;
	}

	void push_front() {
		type_node* temp=new type_node;
		temp->next = _front;
		temp->prev = NULL;
		if(!_front)
			_back = temp;
		else
			_front->prev = temp;
		_front = temp;
		num_nodes++;
	}
	void push_front(const type& t) {
		type_node* temp=new type_node;
		temp->t = t;
		temp->next = _front;
		temp->prev = NULL;
		if(!_front)
			_back = temp;
		else
			_front->prev = temp;
		_front = temp;
		num_nodes++;
	}


	void pop_front() {
		assert(_front != NULL);
		num_nodes--;
		type_node* temp = _front;
		_front = temp->next;
		if(_front)
			_front->prev = NULL;
		else
			_back = NULL;
		delete temp;
	}
	void pop_front(type& t) {
		assert(_front != NULL);
		num_nodes--;
		type_node* temp = _front;
		_front = temp->next;
		if(_front)
			_front->prev = NULL;
		else
			_back = NULL;
		t = temp->t;
		delete temp;
	}
	void pop_back() {
		assert(_back != NULL);
		num_nodes--;
		type_node* temp = _back;
		_back = temp->prev;
		if(_back)
			_back->next = NULL;
		else
			_front = NULL;
		delete temp;
	}
	void pop_back(type& t) {
		assert(_back != NULL);
		num_nodes--;
		type_node* temp = _back;
		_back = temp->prev;
		if(_back)
			_back->next = NULL;
		else
			_front = NULL;
		t = temp->t;
		delete temp;
	}
}