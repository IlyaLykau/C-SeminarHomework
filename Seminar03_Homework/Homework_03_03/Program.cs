// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("результат: ");
Cube();

void Cube()
{
  for (int i = 1; i <= num; i++)
  {
    int x = i * i * i;
    Console.Write($"{x} \t");
  }
  return;
}