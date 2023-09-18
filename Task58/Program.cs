// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = { { 2, 4 }, { 3, 2 } };
int[,] matrix2 = { { 3, 4 }, { 3, 3 } };
int rows1 = matrix1.GetLength(0);
int columns1 = matrix1.GetLength(1);
int columns2 = matrix2.GetLength(1);

int[,] result = new int[rows1, columns2];

for (int i = 0; i < rows1; i++)
{
  for (int j = 0; j < columns2; j++)
  {
    int sum = 0;
    for (int k = 0; k < columns1; k++)
    {
      sum += matrix1[i, k] * matrix2[k, j];
    }
    result[i, j] = sum;
  }
}

void PrintMatrix1(int[,] matrix1)
{
  for (int i = 0; i < matrix2.GetLength(0); i++)
  {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
      Console.Write($"{matrix1[i, j]}" + "\t");
    }
    Console.WriteLine();
  }
}
void PrintMatrix2(int[,] matrix2)
{
  for (int k = 0; k < matrix2.GetLength(0); k++)
  {
    for (int l = 0; l < matrix2.GetLength(1); l++)
    {
      Console.Write($"{matrix2[k, l]}" + "\t");
    }
    Console.WriteLine();
  }
}


Console.WriteLine("Первая матрица");
PrintMatrix1(matrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
PrintMatrix2(matrix2);
Console.WriteLine();

for (int i = 0; i < rows1; i++)
{
  for (int j = 0; j < columns2; j++)
  {
    Console.Write(result[i, j] + "\t");
  }
  Console.WriteLine();
}
