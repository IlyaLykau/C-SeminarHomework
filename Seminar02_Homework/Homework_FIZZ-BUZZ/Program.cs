﻿// Задача необязательная FIZZ BUZZ: Напишите программу, которая выводит на экран числа от 1 до 100. 
// При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, 
// кратных пяти — слово Buzz. Если число кратно пятнадцати, 
// то программа должна выводить слово FizzBuzz. 

for(int i=1; i<101; i++)
    if(i%15==0)
      Console.Write(" FIZZ-BUZZ ");  
    else
      if(i%3==0)
          Console.Write(" Fizz ");
      else
          if(i%5==0)
              Console.Write(" Buzz ");
          else Console.Write(i );