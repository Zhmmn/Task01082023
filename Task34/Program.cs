// 1. Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.

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


int EvenNumbersArray(int[] arr)
{
  int even = 0;

  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0)
    {
      even++;
    }

  }
  return even;
}

int[] array = CreateArrayRndint(10, 100, 1000);
PrintArray(array);
Console.WriteLine();
int evenNumbersArray = EvenNumbersArray(array);
Console.WriteLine($" Количество четных чисел  в массиве : {evenNumbersArray}");