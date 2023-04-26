from collections import deque

class Node:
    def __init__(self, state, parent=None):
        self.state = state
        self.parent = parent

    def __eq__(self, other):
        return self.state == other.state

    def __hash__(self):
        return hash(self.state)

def is_valid(state):
    left_bank = state[:3]
    right_bank = state[3:]
    if left_bank[0] < left_bank[1] and left_bank[0] > 0:
        return False
    if right_bank[0] < right_bank[1] and right_bank[0] > 0:
        return False
    return True

def get_possible_moves(state):
    moves = []
    left_bank = state[:3]
    right_bank = state[3:]
    for i in range(3):
        for j in range(3):
            if i + j > 2:
                continue
            new_left_bank = [left_bank[0]-i, left_bank[1]-j, left_bank[2]+i+j]
            new_right_bank = [right_bank[0]+i, right_bank[1]+j, right_bank[2]-i-j]
            new_state = tuple(new_left_bank + new_right_bank)
            if is_valid(new_state):
                moves.append(new_state)
    return moves

def bfs(start_state, goal_state):
    start_node = Node(start_state)
    goal_node = Node(goal_state)
    visited = set()
    queue = deque([start_node])
    while queue:
        node = queue.popleft()
        if node == goal_node:
            path = []
            while node is not None:
                path.append(node.state)
                node = node.parent
            return path[::-1]
        visited.add(node)
        for move in get_possible_moves(node.state):
            child = Node(move, node)
            if child not in visited:
                queue.append(child)
    return None

start_state = (3, 3, 1, 0, 0, 0)  # (missionaries on left bank, cannibals on left bank, boat on left bank)
goal_state = (0, 0, 0, 3, 3, 1)   # (missionaries on right bank, cannibals on right bank, boat on right bank)
path = bfs(start_state, goal_state)
if path is None:
    print("No solution found")
else:
    print("Solution:")
    for state in path:
        print(state[:3], "| |", state[3:])
