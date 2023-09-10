// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные и 
// замените эти элементы на их квадраты
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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
void EvenIndexSquare(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i += 2)
  {
    for (int j = 0; j < matrix.GetLength(1); j += 2)
    {
      matrix[i, j] *= matrix[i, j];
    }
  }
}


int[,] matrix = CreateMatrixRndint(3, 4, 1, 5);
PrintMatrix(matrix);
EvenIndexSquare(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);

