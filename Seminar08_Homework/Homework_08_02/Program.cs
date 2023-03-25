// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("введите количество элементов квадратного массива:");
int num = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[num, num];

FillArray(array);
PrintArray(array);
SummaLine(array);


void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(1, 10);
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j],3} \t");
    Console.WriteLine();
  }
}

void SummaLine(int[,] array)
{
  int minsum = Int32.MaxValue;
  int indexLine = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum = sum + array[i, j];
    }
    if (sum < minsum)
    {
      minsum = sum;
      indexLine++;
    }
  }
  Console.WriteLine($"строка с min суммой: {indexLine}, сумма елементов равна: {minsum}");
}