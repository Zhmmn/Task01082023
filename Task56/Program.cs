// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int RowSmallestSumOfElements(int[,] mtx)
{
  int rows = mtx.GetLength(0);
  int columns = mtx.GetLength(1);
  int minSum = int.MaxValue;
  int minRow = 0;

  for (int i = 0; i < rows; i++)
  {
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
      sum += mtx[i, j];
    }
    if (sum < minSum)
    {
      minSum = sum;
      minRow = i + 1;
    }

  }
  return minRow;
}
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }
  }
  return matrix;
}


void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}" + "\t");
    }
    Console.WriteLine();
  }
}

int[,] matrix = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int row = RowSmallestSumOfElements(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов =>" + row);