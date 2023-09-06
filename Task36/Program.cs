// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndint(int size, int min, int max)
{
  int[] arr = new int[size];
  Random random = new Random();
  for (int i = 0; i < size; i++)
  {
    arr[i] = random.Next(min, max + 1);
  }
  return arr;
}
void PrintArray(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]} ");
  }
  Console.Write("]");
}

int sumNumbersOddPositionArray(int[] arr)
{
  int oddPosition = 0;
  for (int i = 1; i < arr.Length; i = i + 2)
  {
    oddPosition = (oddPosition + arr[i]);
  }
  return oddPosition;
}

int[] array = CreateArrayRndint(8, 1, 9);
PrintArray(array);
Console.WriteLine();
int SumNumbersOddPositionArray = sumNumbersOddPositionArray(array);
Console.WriteLine($"Сумма чисел на нечетных позициях массива равна {SumNumbersOddPositionArray}");


