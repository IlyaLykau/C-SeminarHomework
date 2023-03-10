// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int basement, int deg)
{
  int res = 1;
  for(int i=0; i < deg; i++)
  {
    res = res * basement;
  }
  return res;
}

bool CheckDeg(int deg)
{
  if(deg < 1)
  {
    Console.WriteLine("степень не должна быть меньше нуля");
    return false;
  }
  else return true;
}

Console.WriteLine("введите основание: ");
int basement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень: ");
int deg = Convert.ToInt32(Console.ReadLine());
if(CheckDeg(deg))
Console.WriteLine("результат: " + Degree(basement, deg));