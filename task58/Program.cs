// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int InputNumber(string input)
{
    
     Console.Write(input);
     int output = Convert.ToInt32(Console.ReadLine());
   return output;
 }

void FillMatrixRandom(int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] +" ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int rows = InputNumber("Колличество строк:");
int columns = InputNumber("Колличество столбцов:");
int[,] matrixA = new int[rows, columns];
int[,] matrixB = new int[rows, columns];
FillMatrixRandom(matrixA);
FillMatrixRandom(matrixB);
int[,] matrixC = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int k = 0; k < columns; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintMatrix(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintMatrix(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintMatrix(matrixC);