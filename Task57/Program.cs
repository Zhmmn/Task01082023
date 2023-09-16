// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateMatrixRndint(int rows, int columns, int min, int max)
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

void PrintArray(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]}");
  }
  Console.WriteLine("]");

}

void PrintMatrix(int[,] matrix)
{
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      Console.Write($"{matrix[i, j]} " + " \t");
    }
    Console.WriteLine("");
  }
}

int[] MatrixToArray(int[,] matrix)
{
  int k = 0;
  int[] array = new int[matrix.Length];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      array[k] = matrix[i, j];
      k++;
    }
  }
  return array;
}

void frequencyDictionary(int[] arr) // frequencydictionary(частотный словарь )
{
  int count = 1;
  int number = arr[0];


  for (int i = 1; i < arr.Length; i++)
  {
    if (arr[i] == number)
    {
      count++;
    }
    else
    {
      Console.WriteLine($"{number} => {count}");
      count = 1;
      number = arr[i];
    }
  }
  Console.WriteLine($"{number} => {count}");
}
int[,] matrix = CreateMatrixRndint(5, 5, 0, 10);
PrintMatrix(matrix);

int[] array = MatrixToArray(matrix);
Array.Sort(array);

Console.WriteLine();
PrintArray(array);
Console.WriteLine();
frequencyDictionary(array);
