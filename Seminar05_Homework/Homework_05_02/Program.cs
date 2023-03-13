// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
  for(int i=0; i<array.Length; i++)
  array[i] = new Random().Next(-10, 10);
}

void PrintArray(int[] array)
{
  foreach(int el in array)
    Console.Write($"{el}  ");
  Console.WriteLine();
}

void Summa(int[] array)
{
  int sum = 0;
  for(int i=1; i<array.Length; i+=2)
  {
      sum = sum + array[i];
  }
Console.WriteLine($"сумма нечетных элементов равна {sum}");
}


Console.WriteLine("введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
FillArray(array);
PrintArray(array);
Summa(array);