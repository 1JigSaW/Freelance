graph = {'Алексей': 'Пётр 1', 
		'Анна': 'Пётр 1', 'Елизавета': 'Пётр 1', 
		'Пётр 2': 'Алексей', 'Пётр 3': 'Анна', 
		'Павел 1': 'Пётр 3', 'Александр 1': 'Павел 1', 
		'Николай 1': 'Павел 1'}

def height(man):
    if man not in graph:
        return 0
    else:
        return 1 + height(graph[man])
 
 
heights = {}
for man in set(graph.keys()).union(set(graph.values())):
    heights[man] = height(man)
 
for key, value in sorted(heights.items()):
    print(f'{key} - {value}')