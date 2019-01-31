# NQueen-Problem                NQUEEN PROBLEM:
INTRODUCTION:
The N Queen is the problem of placing chess queens on an N×N chessboard so that no two queens attack each other where N is the number of chess queens. 
For example, 
following is a solution for 4X4 chessboard Queen Problem.
Here all the queens are arranged in such a way that they can’t attack each other.
Attacking areas of queens are:
queen attacks on the same rank ,same column and diagonally (1ST  : top left to bottom right ,2ND bottom left to top right) .

# WORKING PROCESS:
Here we’re going to use backtracking algorithm to solve this problem.
Now the working process of the algorithm is:
1)	Starting in the leftmost column
2)	If all queen are places return true
3)	Try all rows in the current column .do following for every tried row.  
a)	If the queen can be placed safely in this row then mark this [row, column] as a part of the solution and recursively check if placing     queen here leads to a solution.
b)	If placing the queen in [row, column] leads to a solution then return true.
c)	If placing queen doesn’t lead to a solution then unmark this [row, column] backtrack and go to step “a” to try others rows.
4)	If all rows have been tried and nothing worked return false to trigger backtracking.

# GROUP MEMBERS: 
SYEDA  ZUNAIRA AHMED               17B-103-SE -- SEC”B”
ALIZA WAGAN                        17B-101-SE -- SEC”B”

