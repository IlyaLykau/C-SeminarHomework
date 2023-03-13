// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void FillArray(decimal[] array)
{
  for (int i=0; i<array.Length; i++)
  array[i] = Convert.ToDecimal(new Random().Next(100, 1000))/100;
}

void PrintArray(decimal[] array)
{
  foreach(decimal el in array)
    Console.Write($"{el}  ");
  Console.WriteLine();
}

void Poisk(decimal[] array)
{
  decimal max = array[0];
  decimal min = array[0];
  for(int i=0; i<array.Length; i++)
    if (array[i]>max)
      max = array[i];
    else if (array[i]<min)
      min = array[i];
  Console.WriteLine($"max равен {max}");
  Console.WriteLine($"min равен {min}");
  Console.WriteLine($"разница между min и max состовляет {max - min} ");
}


Console.WriteLine("введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
decimal[] array = new decimal[num];
FillArray(array);
PrintArray(array);
Poisk(array);