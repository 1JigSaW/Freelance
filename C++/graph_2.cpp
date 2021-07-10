#include <iostream>
#include <vector>
#include <string>
using namespace std;

class Vertex {
private:
  string m_colour;
  int m_number;
  int m_discovered_time;
  int m_closed_time;
  vector <int> m_related;

public:
  Vertex () = default;
  Vertex(const Vertex& second) = default;

  explicit Vertex (int num, string new_colour = "colorless") {
    m_colour = new_colour;
    m_number = num;
  }

  ~Vertex() = default;

  void set_colour (string new_colour) {
    m_colour = new_colour;
  }

  string get_colour() const {
    return m_colour;
  }

  void set_number(int num) {
    m_number = num;
  }

  int get_number() const {
    return m_number;
  }

  void set_closed_time(int time) {
    m_closed_time = time;
  }

  int get_closed_time() const {
    return m_closed_time;
  }

  int get_discovered_time() const {
    return m_discovered_time;
  }

  void set_discovered_time(int time) {
    m_discovered_time = time;
  }

  void add_related(const int v) {
    m_related.push_back(v);
  }

  const vector <int>& get_related() const  {
    return m_related;
  }

  bool operator== (const Vertex& v) const {
    return m_number == v.m_number;
  }

  bool operator!= (const Vertex& v) const {
    return !(*this == v);
  }

  Vertex& operator = (const Vertex& v) {
    m_number = v.m_number;
    m_colour = v.m_colour;
    m_related = v.m_related;
    return *this;
  }

};

class Graph {
private:
  int m_time = 0;
  vector<Vertex> graph;
public:
  Graph() = default;
  Graph(int number) {
    for (int i = 0; i < number; ++i) {
      graph.push_back(Vertex(i + 1));
    }
  }

  void add_vertex(int from, int to) {
    graph[from - 1].add_related(to);
    graph[to - 1].add_related(from);
  }

  Vertex& get_vert(int i) {
    return graph[i];
  }

  vector <Vertex>& get_graph() {
    return graph;
  }

  void set_time(int time) {
    m_time = time;
  }

  int get_time() const {
    return m_time;
  }

  void time_update() {
    m_time++;
  }

};


void DFS_visit(Graph& gr, Vertex& v, vector<vector<int>>& comps) {
  v.set_colour("gray");
  gr.time_update();
  v.set_discovered_time(gr.get_time());
  for (int elem : v.get_related()) {
    Vertex& vert = gr.get_vert(elem - 1);
    if (vert.get_colour() == "white") {
      DFS_visit (gr, vert, comps);
      comps.back().push_back(vert.get_number());
    }
  }

  gr.time_update();
  v.set_closed_time(gr.get_time());
  v.set_colour("black");
}

void DFS (Graph& gr, vector<vector<int>>& comps) {
  for (Vertex& cur_vert : gr.get_graph()) {
    cur_vert.set_colour("white");
  }

  gr.set_time(0);

  for (Vertex& cur_vert : gr.get_graph()) {
    if (cur_vert.get_colour() == "white") {
      comps.push_back(vector<int>());
      comps.back().push_back(cur_vert.get_number());
      DFS_visit(gr, cur_vert, comps);
    }
  }

}

int main() {
  int M;
  int N;
  cin >> M >> N;

  Graph graph(M);
  vector<vector<int>> comps;

  int frst, scnd;
  for (int i = 0; i < N; ++i) {
    cin >> frst >> scnd;
    graph.add_vertex(frst, scnd);
  }

  DFS(graph, comps);

  cout << comps.size() << endl;

  for (vector<int>& comp : comps) {
    cout << comp.size() << endl;
    for (int v : comp) {
      cout << v << " ";
    }
    cout << '\n';
  }
}