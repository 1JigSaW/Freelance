#include <iostream>
using namespace std;
const int MAX = 100;
int temp;
int col[MAX];
int matrix[MAX][MAX];
void DFS(int v) {
if (col[v]) {
return;
}
col[v] = 1;
for (int i = 0; i < temp; ++i) {
if (matrix[v][i]) DFS(i);
}
col[v] = 2;
}
int main() {
int c;
cin >> temp >> c;
for (int i = 0; i < c; ++i) {
int a, b;
cin >> a >> b;
matrix[a — 1][b — 1] = 1;
matrix[b — 1][a — 1] = 1;
}
int counter = 0;
for (int i = 0; i < temp; ++i) {
if (col[i] == 0){
counter++;
DFS(i);
}
}
cout << counter;
return 0;
}