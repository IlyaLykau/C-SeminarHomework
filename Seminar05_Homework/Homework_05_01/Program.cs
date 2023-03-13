// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
  for (int i=0; i<array.Length; i++)
  array[i]= new Random().Next(100,1000);
}

void PrintArray(int[] array)
{
  foreach(int el in array)
  {
    Console.Write($"{el}  ");
  }
  Console.WriteLine();
}

void EvenCount(int[] array)
{
  int k = 0;
  for (int i=0; i<array.Length; i++)
    {
      if (array[i] % 2 == 0)
      k+=1;
    }
  Console.WriteLine($"количество четных элементов {k} ");
}

Console.WriteLine("введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int [num];

FillArray(array);
PrintArray(array);
EvenCount(array);