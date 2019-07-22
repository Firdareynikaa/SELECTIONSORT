using System;
using static System.Console;
namespace SELECTION_SORT
{
    class Program
    {
        static void Main()
        {
            int N, S, P; ForegroundColor = ConsoleColor.Yellow;
            Write("\n Jumlah Data = ");
            N = int.Parse(ReadLine());
            int[] A = new int[N];
            Random R = new Random();
            for (int X = 0; X < N; X++)
            { A[X] = R.Next(100, 1000); Write(" {0} ", A[X]); }

            for (int X = 0; X < N - 1; X++)
            {
                S = X; P = X;
                for (int Y = X + 1; Y < N; Y++)
                    if (A[P] > A[Y]) P = Y;

                if (S != P)
                { int C = A[S]; A[S] = A[P]; A[P] = C; }
            }

            WriteLine(); ForegroundColor = ConsoleColor.Green;
            for (int X = 0; X < N; X++) Write(" {0} ", A[X]);
            ReadKey();
        }
    }
}
