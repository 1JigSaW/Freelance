#include <iostream>
#include <stdio.h>
#include <stdlib.h>

using namespace std;

class List
{
private:
    int *el_1_ptr;
    int *el_n_ptr;
    int znach;
    int *next_ptr;
public:
    List()
        : el_1_ptr (0),
        el_n_ptr (0)
    {}

    void insertAtFront (const int & value)
    {
        int *new_ptr = new_el(value);
        
        if ( isEmpty() )
            el_1_ptr = el_n_ptr = new_ptr;
        else
        {
            next_ptr = el_1_ptr;
            el_1_ptr = new_ptr;
        }
    }

    void insertAtBack (const int & value)
    {
        int *new_ptr = new_el(value);

        if ( isEmpty() )
            el_1_ptr = el_n_ptr = new_ptr;
        else
        {
            next_ptr = new_ptr;
            el_n_ptr = new_ptr;
        }
    }

    bool delFromFront (int & value)
    {
        if ( isEmpty() )
            return false;
        else
        {
            int *res_el_ptr = el_1_ptr;
            if ( el_1_ptr == el_n_ptr )
                el_1_ptr = el_n_ptr = 0;
            else
            {
                el_1_ptr = next_ptr;
                value = znach;
                delete res_el_ptr;
                return true;
            }
        }
    }

    bool delFromBack (int & value)
    {
        if ( isEmpty() )
            return false;
        else
        {
            int *res_el_ptr = el_n_ptr;
            if ( el_1_ptr == el_n_ptr )
                el_1_ptr = el_n_ptr = 0;
            else
            {
                int *tek_el_ptr = el_1_ptr;
                while (next_ptr != el_n_ptr)
                    tek_el_ptr = next_ptr;
                el_n_ptr = tek_el_ptr;
                next_ptr = 0;
            }           
            value = znach;
            delete res_el_ptr;
            return true;
        }
    }

    int *new_el (const int & value)
    {
        int v = value;
        return &v;
    }

    bool isEmpty () const
    {
        return el_1_ptr == 0;
    }

    void print () const
    {
        if ( isEmpty() )
        {
            cout << "Spisok pust" << endl;
            return;
        }
        int *tek_el_ptr = el_1_ptr;
        cout << "Spisok sostoit iz: ";
        while (tek_el_ptr != 0)
        {
            cout << *tek_el_ptr << ' ';
            tek_el_ptr = next_ptr;
        }
        cout << endl;
    }

    ~List()
    {
        if (!isEmpty() )
        {
            cout << "Destroying nodes ..." << endl;
            int *el_ptr = el_1_ptr;
            int *res_el_ptr;
            while (el_ptr != 0)
            {
                res_el_ptr = el_ptr;
                cout << znach << endl;
                el_ptr = next_ptr;
                delete res_el_ptr;
            }
        }
        cout<< "All nodes destroyed" <<endl;
    }
};