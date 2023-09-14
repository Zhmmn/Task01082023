// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое
// каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

public class Answer
{
  public static void PrintArray(int[,] matrix)
  {
    // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        Console.Write($"{matrix[i, j]} " + " \t");
      }
      Console.WriteLine("");
    }

  }

  public static int[,] CreateIncreasingMatrix(int n, int m, int k)
  {
    // Введите свое решение ниже
    int[,] matrix = new int[n, m];
    int number = 1;
    for (int i = 0; i < n; i++)
    {
      for (int j = 0; j < m; j++)
      {
        matrix[i, j] = number;
        number += k;
      }
    }
    return matrix;
  }

  static void PrintListAvr(double[] list)
  {
    // Введите свое решение ниже
    Console.WriteLine("The averages in columns are: ");
    foreach (double average in list)
    {
      Console.Write($"{average:F2}" + "\t");
    }
    Console.WriteLine("");
  }

  static double[] FindAverageInColumns(int[,] matrix)
  {
    // Введите свое решение ниже
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    double[] averages = new double[columns];
    for (int i = 0; i < columns; i++)
    {
      double sum = 0;
      for (int j = 0; j < rows; j++)
      {
        sum += matrix[j, i];
      }
      averages[i] = sum / rows;
    }
    return averages;
  }
  // Не удаляйте и не меняйте метод Main! 
  public static void Main(string[] args)
  {
    int n, m, k;
    if (args.Length >= 3)
    {
      n = int.Parse(args[0]);
      m = int.Parse(args[1]);
      k = int.Parse(args[2]);
    }
    else
    {
      // Здесь вы можете поменять значения для отправки кода на Выполнение
      n = 3;
      m = 4;
      k = 2;
    }
    // Не удаляйте строки ниже
    int[,] result = CreateIncreasingMatrix(n, m, k);
    PrintArray(result);
    PrintListAvr(FindAverageInColumns(result));
  }
}