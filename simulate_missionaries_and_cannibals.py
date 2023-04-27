import queue

# Define the valid moves
MOVES = [(1, 0), (2, 0), (0, 1), (0, 2), (1, 1)]

# Define the initial and goal states
INIT_STATE = (3, 3, 0, 0, 1)
GOAL_STATE = (0, 0, 3, 3, -1)

def is_valid(state):
    """Check if a state is valid."""
    left_m, left_c, right_m, right_c, boat_pos = state
    if left_m < 0 or left_c < 0 or right_m < 0 or right_c < 0:
        return False
    if left_c > left_m > 0 or right_c > right_m > 0:
        return False
    return True

def apply_move(state, move):
    """Apply a move to a state."""
    left_m, left_c, right_m, right_c, boat_pos = state
    move_m, move_c = move
    if boat_pos == 1:
        left_m -= move_m
        left_c -= move_c
        right_m += move_m
        right_c += move_c
        boat_pos = -1
    else:
        left_m += move_m
        left_c += move_c
        right_m -= move_m
        right_c -= move_c
        boat_pos = 1
    return (left_m, left_c, right_m, right_c, boat_pos)

def dfs():
    """Perform a depth-first search."""
    visited = set()
    stack = [(INIT_STATE, [])]
    while stack:
        state, path = stack.pop()
        if state == GOAL_STATE:
            return path
        if state not in visited:
            visited.add(state)
            for move in MOVES:
                new_state = apply_move(state, move)
                if is_valid(new_state) and new_state not in visited:
                    stack.append((new_state, path + [move]))

def bfs():
    """Perform a breadth-first search."""
    visited = set()
    q = queue.Queue()
    q.put((INIT_STATE, []))
    while not q.empty():
        state, path = q.get()
        if state == GOAL_STATE:
            return path
        if state not in visited:
            visited.add(state)
            for move in MOVES:
                new_state = apply_move(state, move)
                if is_valid(new_state) and new_state not in visited:
                    q.put((new_state, path + [move]))

# Test the algorithms
print("DFS solution:", dfs())
print("BFS solution:", bfs())
