// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] ArrangeElementsInDescendingOrder(int[,] mtx)
{
  int rows = mtx.GetLength(0);
  int columns = mtx.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      for (int k = 0; k < columns - j - 1; k++)
      {
        if (mtx[i, k] < mtx[i, k + 1])
        {
          int temp = mtx[i, k];
          mtx[i, k] = mtx[i, k + 1];
          mtx[i, k + 1] = temp;
        }
      }
    }
  }
  return mtx;
}

int[,] CreateMatrixRandomInt(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = rnd.Next(min, max);
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

int[,] matrix = CreateMatrixRandomInt(4, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[,] mtx = ArrangeElementsInDescendingOrder(matrix);
PrintMatrix(mtx);