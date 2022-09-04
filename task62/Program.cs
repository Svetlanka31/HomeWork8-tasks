// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


    
 void PrintMatrix (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
  }
}
Console.WriteLine("Введите размерность массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,]Matrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= n * n)
{
  Matrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)  j++;
  else if (i < j && i + j >= Matrix.GetLength(0) - 1) i++;
  else if (i >= j && i + j > Matrix.GetLength(1) - 1) j--;
  else
    i--;
}

PrintMatrix(Matrix);
