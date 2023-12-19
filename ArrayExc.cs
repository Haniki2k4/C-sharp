using System;

public class MaxSubMatrix
{
    public int MaxSub(int[][] matrix, int K)
    {
        int N = matrix.Length;
        int M = matrix[0].Length;

        int maxSum = int.MinValue;

        for (int i = 0; i <= N - K; i++)
        {
            for (int j = 0; j <= M - K; j++)
            {
                int currentSum = 0;
                for (int row = i; row < i + K; row++)
                {
                    for (int col = j; col < j + K; col++)
                    {
                        currentSum += matrix[row][col];
                    }
                }
                maxSum = Math.Max(maxSum, currentSum);
            }
        }

        return maxSum;
    }
}

class Program
{
    static void Main()
    {
        MaxSubMatrix matrix = new MaxSubMatrix();

        Console.WriteLine("Enter the size of the matrix (N x M):");
        Console.Write("N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("M: ");
        int M = int.Parse(Console.ReadLine());

        int[][] inputMatrix = new int[N][];
        for (int i = 0; i < N; i++)
        {
            inputMatrix[i] = new int[M];
            for (int j = 0; j < M; j++)
            {
                Console.Write($"Enter element at position [{i}][{j}]: ");
                inputMatrix[i][j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter the size of the submatrix (K x K):");
        int K = int.Parse(Console.ReadLine());

        int result = matrix.MaxSub(inputMatrix, K);
        Console.WriteLine("Maximum sum of submatrix of size " + K + "x" + K + " is: " + result);
        Console.ReadKey();
    }
    
}
