// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите 2 натуральных числа");
System.Console.WriteLine("Число M : ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Число N : ");
int m = Convert.ToInt32(Console.ReadLine());

int min = 0;
int max = 0;
if (m < n)
{
  min = m;
  max = n;
}
else
{
  min = n;
  max = m;
}

int SumNaturalElements(int min, int max) // 1.15. 2.15 
{
  if (min > max) return 0;
  return min + SumNaturalElements(min + 1, max);  // stec 1.15 2.15
}

void DemonstrationOfNumbers(int m, int n)
{
  if (m < n)
  {
    Console.Write($"{m} ");
    DemonstrationOfNumbers(m + 1, n);
  }
  else if (m > n)
  {
    Console.Write($"{m} ");
    DemonstrationOfNumbers(m - 1, n);
  }
  else
  {
    Console.Write($"{m} ");
  }
}
int sum = SumNaturalElements(min, max);

if (m > n)
{
  DemonstrationOfNumbers(min, max);
}
else
{
  DemonstrationOfNumbers(max, min);
}

Console.WriteLine();
System.Console.WriteLine($"Сумма натуральных элементов в заданном промежутке равна {sum}");
