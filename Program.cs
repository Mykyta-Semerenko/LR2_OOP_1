using System;


namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть розмір матриці M: ");
            int M = Convert.ToInt32(Console.ReadLine());


            if (M <= 0)
            {
                Console.WriteLine("Розмір повинен бути більше 0!");
                return;
            }


            int[,] A = new int[M, M];


            ReadArray(A);


            Console.WriteLine("\nПочатковий масив:");
            PrintArray(A);


            MoveZerosDown(A);


            Console.WriteLine("\nМасив після переміщення нулів:");
            PrintArray(A);


            Console.ReadKey();
        }
        static void ReadArray(int[,] A)
        {
            int M = A.GetLength(0);


            Console.WriteLine("Введіть елементи матриці:");


            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void MoveZerosDown(int[,] A)
        {
            int M = A.GetLength(0);
            int N = A.GetLength(1);


            for (int j = 0; j < N; j++)
            {
                int row = 0;


                for (int i = 0; i < M; i++)
                {
                    if (A[i, j] != 0)
                    {
                        A[row, j] = A[i, j];
                        row++;
                    }
                }


                while (row < M)
                {
                    A[row, j] = 0;
                    row++;
                }
            }
        }
        static void PrintArray(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "\t");
                }


                Console.WriteLine();
            }
        }
    }
}