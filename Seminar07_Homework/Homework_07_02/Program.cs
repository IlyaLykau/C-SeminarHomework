// Задача 50. Напишите программу, которая на вход 
// принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
Poisk(array);


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

void Poisk(int[,] array)
{
  if (num > array.GetLength(0) && num > array.GetLength(1))
    Console.WriteLine($"{num} - такого числа в массиве нет");
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      if (num == array[i, j]) Console.WriteLine($"позиция числа {num}: rows = {0},cols = {1}", i, j);
}