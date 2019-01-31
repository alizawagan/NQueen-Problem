using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQUEEN_PROBLEM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            Nqueen q = new Nqueen(n);
            int[,] Chess = new int[n, n];
            q.solvequeen(Chess, 0);
            q.display(Chess);
        }
    }

    class Nqueen
    {
        public int[,] Chess;
        public int N;

        public Nqueen(int n)
        {
            N = n;
            Chess = new int[N, N];
        }
        public bool safe(int[,] Chess, int row, int col)
        {
            int i;
            int j;
            for (i = 0; i < col; i++)

                if ((Chess[row, i] == 1))  //Check left side of row

                    return false;

            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)  //upper diagonal check
                if (Chess[i, j] == 1)
                    return false;
            for (i = row, j = col; j > 0 && i < N; i++, j--) //lower digonal check
                if (Chess[i, j] == 1)
                    return false;

            return true;

        }
        public void display(int[,] Chess)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Chess[i, j] == 1)
                    {
                        Console.Write("Q");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }

        }
        public bool solvequeen(int[,] Chess, int col)
        {
            if (col >= N)              //if all queens are placed
                return true;
            for (int i = 0; i < N; i++)   //consider this column and try placing this queen in all rows one by one 
            {
                if (safe(Chess, i, col))
                {
                    Chess[i, col] = 1;
                    if (solvequeen(Chess, col + 1))  // to place rest of the queens 
                    {
                        return true;
                    }
                    Chess[i, col] = 0; //backtracking
                }
            }

            return false;
        }
    }
}
