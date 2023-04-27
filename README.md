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

#### The chart illustrates the high-level structure of the Python code provided.

#### At the top of the chart, there are two boxes labeled "Import Libraries" and "Global Variables". The first box contains the queue module import statement, and the second box lists the global variables "MOVES", "INIT_STATE", and "GOAL_STATE".

#### The next three boxes represent the three helper functions used in the code: "is_valid()", "apply_move()", and "dfs()". "The is_valid()" function checks if a given state is valid according to the rules of the game. The "apply_move()" function applies a given move to a given state and returns the resulting state. The "dfs()" function performs a depth-first search algorithm to find a solution to the game.

#### The next box represents the "bfs()" function, which performs a breadth-first search algorithm to find a solution to the game.

#### Finally, the last box represents the main code, which tests the algorithms and prints the results to the console. It first calls the "dfs()" function and prints the solution returned by it, then it calls the "bfs()" function and prints the solution returned by it.
