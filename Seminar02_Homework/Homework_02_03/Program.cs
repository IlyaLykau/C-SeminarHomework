// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите цифру дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1 || num > 7)
  Console.WriteLine("это не день недели");
else if (num == 6 || num == 7)
  Console.WriteLine("это выходной");
else if (num > 1 || num < 6)
  Console.WriteLine("это рабочий день");
