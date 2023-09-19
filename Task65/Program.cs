// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите натуральное число");
Console.WriteLine("Введите первое значение: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

void RangeNaturalNumbers(int firstNumber, int secondNumber)
{
  if (firstNumber < secondNumber)
  {
    Console.Write($"{firstNumber} ");
    RangeNaturalNumbers(firstNumber + 1, secondNumber);
  }
  else if (firstNumber > secondNumber)
  {
    Console.Write($"{firstNumber} ");
    RangeNaturalNumbers(firstNumber - 1, secondNumber);
  }
  else
  {
    Console.Write($"{firstNumber}");
  }
}

RangeNaturalNumbers(firstNumber, secondNumber);