﻿// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("И снова здравствуйте!");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (number1 > number2) 
{
   max = number1; 
}
else 
{
    max = number2;
}
if (number3 > max) 
{
      max = number3;
   Console.WriteLine("Максимальное число: " + max);
    Console.WriteLine("Всего Доброго! Хорошего дня!");
}
else 
{
    Console.WriteLine("Максимальное число: " + max);
     Console.WriteLine("Всего Доброго! Хорошего дня!");
}