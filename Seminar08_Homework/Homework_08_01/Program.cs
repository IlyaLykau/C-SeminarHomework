﻿// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов:");
int cols = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
Order(array);
Console.WriteLine();
Console.WriteLine("измененный массив:");
PrintArray(array);


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

void Order(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
  for (int j = 0; j < array.GetLength(1) - 1; j++)
    for (int z = 0; z < array.GetLength(1) - 1; z++)
    {
      if (array[i, z] < array[i, z + 1])
      {
        int temp = 0;
        temp = array[i, z];
        array[i, z] = array[i, z + 1];
        array[i, z + 1] = temp;
      }
    }
}