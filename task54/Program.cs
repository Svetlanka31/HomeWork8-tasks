// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
const int ROWS = 4;
const int COLUMNS =4;
int [,]FillMatrix(int rows, int columns, int leftRange = 0, int rigthRange = 10)
{
Random rand = new Random();
int [,] matrix = new int[rows,columns];
for(int i = 0; i < rows; i++)
{
  for (int j = 0; j < columns; j++)
  {
    matrix[i,j] = rand.Next(leftRange,rigthRange);
  }
  }
  return matrix;
} 

void PrintMatrix(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

{
 
    
}
int[,] matrix = FillMatrix(ROWS,COLUMNS);
PrintMatrix(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < matrix.GetLength(1) - 1; z++)
        {
            if (matrix[i, z] < matrix[i, z + 1]) 
            {
                int temp = 0;
                temp = matrix[i, z];
                matrix[i, z] = matrix[i, z + 1];
                matrix[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintMatrix(matrix);
