#include <string>


class Animal {
public:
    virtual std::string voice() const {
        return "Not implemented yet";
    }
    virtual ~Animal() {
    }
};


class Tiger : public Animal {
    std::string voice() const override {
        return "Rrrr";
    }
};


class Wolf : public Animal {
    std::string voice() const override {
        return "Wooo";
    }
};


class Fox : public Animal {
    std::string voice() const override {
        return "Tyaf";
    }
};

#include <iostream>
#include <memory>
#include <stdexcept>
#include <vector>

using Zoo = std::vector<std::unique_ptr<Animal>>;

Zoo CreateZoo() {
    Zoo zoo;
    std::string word;
    while (std::cin >> word) {
        if (word == "Tiger") {
            zoo.push_back(std::make_unique <Tiger>());
        }
        else if (word == "Wolf") {
            zoo.push_back(std::make_unique <Wolf>());
        }
        else if (word == "Fox") {
            zoo.push_back(std::make_unique <Fox>());
        }
        else {
            throw std::runtime_error("Unknown animal!");
        }
    }
    return zoo;
}

void Process(const Zoo& zoo) {
    for (const auto& animal : zoo) {
        std::cout << animal->voice() << "\n";
    }
}