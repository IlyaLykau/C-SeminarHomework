// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

void FillArray(int m)
{
  for (int i = 0; i < m; i++)
  {
    Console.WriteLine($"Введите {i + 1} элемент массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Summa(int[] array)
{
  int i = 0;
  int sum = 0;
  while (i < array.Length)
  {
    if (array[i] > 0)
      sum += 1;
    i++;
  }
  return sum;
}

FillArray(m);
Console.Write($"\n Чисел больше нуля: {Summa(array)}  ");