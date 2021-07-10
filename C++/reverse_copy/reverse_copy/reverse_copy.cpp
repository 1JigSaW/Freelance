#include <iostream>

template <typename InIter, typename OutIter>
OutIter ReverseCopy(InIter first, InIter last, OutIter out) {
    while (first != last) {
        --last;
        *out = *last;
        ++out;
    }
    return out;
};

