// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// n = 3, m = 2 -> A(m,n) = 29

int n = 3;
int m = 2;

int AckermannFunction(int n, int m)
{
  while (n != 0)
  {
    if (m == 0)
    {
      m = 1;
    }
    else
    {
      m = AckermannFunction(n, m - 1);
    }
    n -= 1;
  }
  return m + 1;
}

int Ack = AckermannFunction(n, m);
System.Console.WriteLine(Ack);