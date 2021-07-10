#include <iostream>
#include <vector>

void delete_zeros(std::vector<int>& numbers) {
    numbers.erase(std::remove(numbers.begin(), numbers.end(), 0), numbers.end());
}

int main()
{
    std::vector<int> v = { 7, 5, 0, 8 };
    delete_zeros(v);
    for (std::vector<int>::iterator it = v.begin(); it != v.end(); ++it)
        std::cout << *it << " ";
    return 0;
}

