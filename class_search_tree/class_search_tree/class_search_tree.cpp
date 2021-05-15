#pragma once

#include <iostream>
#include <vector>

class SearchTree {
private:
    int value_;
    SearchTree* parent_ = nullptr;
    SearchTree* left_ = nullptr;
    SearchTree* right_ = nullptr;

public:
    SearchTree(int value) : value_(value) {
    }

    SearchTree(const SearchTree&) = delete;
    SearchTree& operator=(const SearchTree&) = delete;

    SearchTree* Insert(int value) {
        if (value_ == value)
            return this;

        if (value_ > value) {
            if (left_ == nullptr) {
                left_ = new SearchTree(value);
                left_->parent_ = this;
                return left_;
            }

            return left_->Insert(value);
        }

        if (right_ == nullptr) {
            right_ = new SearchTree(value);
            right_->parent_ = this;
            return right_;
        }

        return right_->Insert(value);
    }

    void Print() const {
        if (left_)
            left_->Print();

        std::cout << value_ << " ";
        if (right_)
            right_->Print();

    }
};

int main() {
    SearchTree tree(5);
    for (int i = 0; i <= 10; ++i) {
        tree.Insert(i);
    }

    tree.Print();
    std::cout << "\n";
}