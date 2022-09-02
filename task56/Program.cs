// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


int[,] matrix = FillMatrix(ROWS,COLUMNS);
PrintMatrix(matrix);

 int minSumNumber =Int32.MaxValue;
int indexString = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
   
    int sum =0;
  for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];        
    }
    if (sum < minSumNumber)
    {
        minSumNumber = sum;
        indexString++;
    }
 }

Console.WriteLine("строка с наименьшей суммой елементов под номером: " 
+ (indexString) + ", с суммой елементов равной: " + (minSumNumber));