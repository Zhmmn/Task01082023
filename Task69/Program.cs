// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Prompt(string message)
{
  Console.Write(message);
  int value = Convert.ToInt32(Console.ReadLine());
  return value;
}

void Validation(int num)
{
  while (num < 1)
  {
    num = Prompt("Неверно введено число. Введите целочисленное число: ");
  }
}

int Exponentiation(int firstNumber, int secondNumber) // 1.1)3.5; 2.1)3.4; 3.1)3.3; 4.1)3.2; 5.1) 3.1
{
  if (secondNumber == 0) return 1;
  ;
  return firstNumber * Exponentiation(firstNumber, secondNumber - 1); // Это стек : число А = 3, число В = 5; 1)3.5; 2)3.4; 3)3.3; 4)3.2; 5)3.1
}                                                                     // 3*3*3*3*3*1= 243

int firstNumber = Prompt("Введите первое число A: ");
int secondNumber = Prompt("Введите второе число B: ");
Validation(secondNumber);


Console.WriteLine($"Число А в степени В равна {Exponentiation(firstNumber, secondNumber)}");