// 1. Задача 38: Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, double max, double min)
{
  double[] arr = new double[size];
  Random random = new Random();
  for (int i = 0; i < size; i++)
  {
    double x = random.NextDouble() * (max - min) * min;
    arr[i] = Math.Round(x * random.NextDouble(), 2);


  }
  return arr;
}
void PrintArray(double[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]} ");
  }
  Console.Write("]");
}

double differenceMaxMin(double[] arr)
{
  double max = arr[0];
  double min = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (max < arr[i]) max = arr[i];
    if (min > arr[i]) min = arr[i];
  }
  return max - min;
}

double[] array = CreateArrayRndDouble(5, 10, 1);
PrintArray(array);
Console.WriteLine();
double DifferenceMaxMin = differenceMaxMin(array);

Console.WriteLine($"Разница {DifferenceMaxMin:F2}");