// Задача 51: Задайте двумерный массив. 
// найдитк сумму элементов, находящихся на главной диагонали 
// с индексами 0,0 1,1 2,2
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] CreateMatrixRndint(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
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
    Console.Write("[");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],6}");
    }
    Console.WriteLine("   ]");
  }
}
int SumBothCommonIndexes(int[,] matrix)
{
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);
  int sum = 0;

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i == j) sum += matrix[i, j];
    }
  }
  return sum;

}

int[,] matrix = CreateMatrixRndint(3, 4, 1, 5);
PrintMatrix(matrix);
int sum = SumBothCommonIndexes(matrix);
System.Console.WriteLine(sum);
