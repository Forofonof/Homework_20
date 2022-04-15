using System;

    internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int[,] matrix = new int[10, 10];
        int maximumNumber = int.MinValue;
        int replacement = 0;

        Console.WriteLine("Исходная матрица:\n");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                matrix[i, j] = random.Next(1, 10);
                Console.Write($"{matrix[i, j]} ");

                if (maximumNumber < matrix[i, j]) 
                {
                    maximumNumber = matrix[i, j];
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine($"\nНаибольший элемент: {maximumNumber}");
        Console.WriteLine($"Итоговая матрица:\n");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                if (maximumNumber == matrix[i, j]) 
                {
                    matrix[i, j] = replacement;
                }
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}