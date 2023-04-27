# MissionariesAndCannibals_Ai_Project
#### Missionaries and Cannibals is a classic puzzle game that involves three missionaries and three cannibals who are on one side of a river, along with a boat that can carry up to two people at a time. The objective of the game is to transport all the people from one side of the river to the other side, without ever allowing the number of cannibals on either side of the river to exceed the number of missionaries.

#### The game starts with all six people and the boat on one side of the river. The player must then make a sequence of moves, each move consisting of the player choosing two people to cross the river in the boat. If at any time the number of cannibals on either side of the river is greater than the number of missionaries, the game is lost. The game is won when all six people are on the other side of the river, with no more than three people in the boat at any given time.



--------------------
#### This is a Python implementation of the Missionaries and Cannibals game using both a Depth-First Search (DFS) algorithm and a Breadth-First Search (BFS) algorithm to solve it.

#### First, the "State" class is defined to represent the current state of the game. It contains five attributes: the number of missionaries and cannibals on the left bank ("left_m", "left_c"), the number of missionaries and cannibals on the right bank ("right_m", "right_c"), and the position of the boat ("boat_pos", where 1 represents the left bank and -1 represents the right bank).

#### Next, the "dfs_search" function is defined to perform a depth-first search of the game's state space. It takes a "start_state" and "goal_state" as input and returns the optimal path from the "start_state" to the "goal_state". It does this by recursively exploring each possible move from the current state until it reaches the "goal_state" or all possible paths have been explored.

#### Similarly, the "bfs_search" function performs a breadth-first search of the game's state space to find the optimal path from the "start_state" to the "goal_state". It uses a "queue" to store the states to be explored, and it explores all possible moves from the current state before moving on to the next level of the state space.

#### Finally, the "main" function is defined to set up the game and run both search algorithms to find the optimal solution. It starts by initializing the "start_state" and "goal_state". Then, it calls the "dfs_search" and "bfs_search" functions to find the optimal paths using the DFS and BFS algorithms, respectively. It prints out the optimal paths and their lengths for comparison.


## The Outputs:

#### The output will be printed to the console, with the DFS and BFS solutions printed on separate lines. For example:
```
DFS solution: [(2, 0), (0, 2), (1, 1), (0, 2), (0, 1), (2, 0), (0, 1), (1, 1), (0, 2)]
BFS solution: [(0, 2), (0, 1), (1, 1), (0, 2), (2, 0), (0, 1), (1, 1), (0, 2), (2, 0)]

```
#### Note that the solutions may be different between the DFS and BFS algorithms, as they use different search strategies.

## Here is a simple flow chart:

```
          +----------------+
          |   Start        |
          +--------+-------+
                   |
                   V
          +----------------+
          |   Define Moves  |
          +--------+-------+
                   |
                   V
          +----------------+
          | Define States  |
          +--------+-------+
                   |
                   V
          +----------------+
          |   Check Valid   |
          +--------+-------+
                   |
                   V
          +----------------+
          |  Apply Move    |
          +--------+-------+
                   |
                   V
          +----------------+
          | Perform DFS/BFS|
          +--------+-------+
                   |
                   V
          +----------------+
          |   Print Result |
          +--------+-------+
                   |
                   V
          +----------------+
          |     End        |
          +----------------+


```

#### This is a flowchart representing the high-level steps of the code. It starts at the "Start" node, then moves to "Define Moves", where the valid moves for the problem are defined. The next step is "Define States", where the initial and goal states for the problem are defined. The next step is "Check Valid", which checks if a given state is valid according to the problem constraints. The next step is "Apply Move", which applies a move to a given state. The next step is "Perform DFS/BFS", which performs either a depth-first search or breadth-first search to find a solution to the problem. The final step is "Print Result", which prints the solution found by the search algorithm. The flowchart ends at the "End" node.

### Youtube: [Link](https://youtu.be/u2goGGnUXZw)
