# MissionariesAndCannibals_Ai_Project
### Missionaries and Cannibals is a classic puzzle game that involves three missionaries and three cannibals who are on one side of a river, along with a boat that can carry up to two people at a time. The objective of the game is to transport all the people from one side of the river to the other side, without ever allowing the number of cannibals on either side of the river to exceed the number of missionaries.

### The game starts with all six people and the boat on one side of the river. The player must then make a sequence of moves, each move consisting of the player choosing two people to cross the river in the boat. If at any time the number of cannibals on either side of the river is greater than the number of missionaries, the game is lost. The game is won when all six people are on the other side of the river, with no more than three people in the boat at any given time.

### The game is often used as a problem-solving exercise, as it requires the player to think critically and make strategic decisions in order to achieve the goal. The game can be played with different variations, such as having more or fewer people, a larger or smaller boat, or different constraints on the movements of the boat.

--------------------
### The code begins by defining a "Node" class, which represents a state in the game. Each node has a "state" attribute, which is a tuple of six integers representing the number of missionaries and cannibals on each side of the river, as well as the position of the boat (0 for left, 1 for right). The "Node" class also has a "parent" attribute, which is used to keep track of the path to the current state.

### The "is_valid" function checks whether a given state is valid according to the game's rules. Specifically, it checks whether the number of cannibals on either side of the river is greater than the number of missionaries on that side (which would be an invalid state).

### The "get_possible_moves" function generates all possible valid moves from a given state. It does this by considering all possible combinations of one or two people to send across the river (since the boat can carry up to two people). For each combination, it calculates the new state that would result from making that move, and checks whether the new state is valid using the "is_valid" function.

### The "bfs" function performs a breadth-first search starting from the "start_state" and searching for the "goal_state". It maintains a set of visited states to avoid revisiting states that have already been explored. It uses a "deque" to implement the breadth-first search algorithm, with nodes being added to the end of the queue and removed from the front. When a goal state is found, the function constructs the path to the goal by following the "parent" pointers from the goal node back to the start node.

### Finally, the code sets the start_state and goal_state variables to the initial and final states of the game, respectively, and calls the "bfs" function to find the solution path. If a solution is found, the code prints out the sequence of states in the solution path.

## The Outputs:
```


Path found:

(3, 3, 0, 0, 0, 1)

(3, 2, 1, 0, 1, 0)

(3, 3, 0, 0, 0, 1)

(2, 2, 1, 1, 1, 0)

(2, 3, 0, 1, 0, 1)

(3, 3, 0, 0, 0, 0)

(3, 1, 1, 0, 2, 1)

(3, 2, 0, 0, 1, 0)

(3, 0, 1, 0, 3, 1)

(3, 1, 0, 0, 2, 0)

(1, 1, 1, 2, 2, 1)

(2, 2, 0, 1, 1, 0)

(0, 2, 1, 3, 1, 1)

(0, 3, 0, 3, 0, 0)

(0, 1, 1, 3, 2, 1)

(0, 2, 0, 3, 1, 0)

(0, 0, 1, 3, 3, 1)

```


## Here is a simple flow chart:

```
graph TD;
        (3,3,0,0,0,0)
        |
   (3,2,1,0,1,0)
   /           \
(3,3,0,0,0,1) (2,2,1,1,1,0)
 |           |    /   \
 |           |(2,3,0,1,0,1)
 |           |   |     |
 |           |(3,3,0,0,0,0)
 |           |   |     |
 |           |(3,1,1,0,2,1)
 |           |   \   /
 |           |(3,2,0,0,1,0)
 |           |     |
 |           |(3,0,1,0,3,1)
 |           |     |
 |           |(3,1,0,0,2,0)
 |           |    /   \
 |           |(1,1,1,2,2,1)
 |           |   |     |
 |           |(2,2,0,1,1,0)
 |           |    \   /
 |           |(0,2,1,3,1,1)
 |           |     |
 |           |(0,3,0,3,0,0)
 |           |     |
 |           |(0,1,1,3,2,1)
 |           |    /   \
 |           |(0,2,0,3,1,0)
 |           |(0,0,1,3,3,1)

```

### Each node in the diagram represents a state in the solution path, with the first three integers representing the number of missionaries on the left side, the next three integers representing the number of cannibals on the left side, and the last integer representing the position of the boat. The edges between nodes represent valid moves in the game, with the boat carrying either one or two people (either missionaries or cannibals) at a time. The starting state is at the top of the diagram, and the goal state is at the bottom.
