import pandas as pd
import numpy as np
import heapq


def read_excel_graph(file_path, sheet_name=0):
    df = pd.read_excel(file_path, sheet_name=sheet_name, header=None)
    graph = df.to_numpy()
    return graph


def dijkstra(graph, start_node):
    num_nodes = len(graph)
    distances = {i: float('inf') for i in range(num_nodes)}
    distances[start_node] = 0
    previous_nodes = {i: None for i in range(num_nodes)}
    priority_queue = [(0, start_node)]

    while priority_queue:
        current_distance, current_node = heapq.heappop(priority_queue)

        if current_distance > distances[current_node]:
            continue

        for neighbor, weight in enumerate(graph[current_node]):
            if weight == 0 or neighbor == current_node:
                continue
            new_distance = int(current_distance) + int(weight)

            if new_distance < distances[neighbor]:
                distances[neighbor] = new_distance
                previous_nodes[neighbor] = current_node
                heapq.heappush(priority_queue, (new_distance, neighbor))

    return distances, previous_nodes


def reconstruct_path(previous_nodes, target):
    path = []
    while target is not None:
        path.append(f"x{target + 1}")
        target = previous_nodes[target]
    return " -> ".join(reversed(path))


def main(file_path, start_node_index):
    graph = read_excel_graph(file_path)
    distances, previous_nodes = dijkstra(graph, start_node_index)

    for node, distance in distances.items():
        if node != start_node_index:
            path = reconstruct_path(previous_nodes, node)
            print(f"x{node + 1}: кратчайший путь - {distance} ({path})")


main("graph.xlsx", 0)
