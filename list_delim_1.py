class list_divider(list):
    def __truediv__(self, other):
        if type(other) != int:
            raise TypeError
        if other > len(self) or other <= 0:
            raise ValueError
        minim = len(self) // other
        extr_num = len(self) % other
        rest_num = other - extr_num
        ans = []
        pos = 0
        for i in range(extr_num):
            ans.append([])
            need = minim + 1
            for j in range(need):
                ans[-1].append(self[pos])
                pos += 1

        for i in range(rest_num):
            ans.append([])
            need = minim
            for j in range(need):
                ans[-1].append(self[pos])
                pos += 1
        return ans
