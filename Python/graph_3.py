from sys import stdin
input = stdin.readline
sys.setrecursionlimit(100)
n, m = map(int, input().split())
G = [[] for i in range(n + 1)]

for i in range(m):
    s = input()
    l = s.split()
    G[int(l[0])].append(int(l[1]))
    G[int(l[1])].append(int(l[0]))
a = [0 for i in range(n + 1)]

def f(i, com):
    if a[i] == 0:
        a[i] = 1
        for j in G[i]:
            com += f(j, [])
        com.append(i)
    return com

list_of_com = list()
for  i in range(1, n + 1):
    list_of_com.append(f(i, list()))
    if list_of_com[-1] == []:
        list_of_com.pop(-1)
print(len(list_of_com))
print(' '.join(list(map(str, sorted(list_of_com[i])))))