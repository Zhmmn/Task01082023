// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
  Console.WriteLine("Некорректный ввод");
  return;
}

int SumDigit(int number)
{
  if (number == 0) return 0;
  ;
  return number % 10 + SumDigit(number / 10);
}
int num = SumDigit(number);
Console.WriteLine($"Сумма цифр числа [{number}]равна {num}");