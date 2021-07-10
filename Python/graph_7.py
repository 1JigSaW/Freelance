import sys
sys.setrecursionlimit(1000000000)
n, m = map(int, input().split())
num_components = 0
lst = [[] for i in range(n)]
temp = []
ans = []


for i in range(m):
    v1, v2 = map(int, input().split())
    lst[v1 - 1].append(v2 - 1)
    lst[v2 - 1].append(v1 - 1)



def dfs(v):
    temp.append(v)
    visited[v] = True
    for w in lst[v]:
        if not visited[w]:
            dfs(w)
visited = [False] * n


for v in range(n):
    if not visited[v]:
        dfs(v)
        ans.append([x for x in temp])
        num_components += 1
        temp.clear()


print(num_components)
for i in ans:
    print(len(i))
    i.sort()
    print(' '.join(str(x + 1) for x in i))