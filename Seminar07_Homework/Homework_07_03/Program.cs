// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов:");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
AverageCols(array);

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(1, 6);
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

void AverageCols(int[,] array)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
      average = average + array[i, j];
    average = average / cols;
    Console.WriteLine($"Ср. арифметическое столбца равно: {average}");
  }
}