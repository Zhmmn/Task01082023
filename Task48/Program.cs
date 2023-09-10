// Задача 48: Задайте двумерный массив размера i на j,
// каждый элемент в массиве находится по формуле: Aₘₙ = i + j.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


int[,] CreateMatrixRndSumIndexes(int rows, int columns)
{
  int[,] matrix = new int[rows, columns];
  // Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = i + j;
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
int[,] array2d = CreateMatrixRndSumIndexes(3, 4);
PrintMatrix(array2d);
