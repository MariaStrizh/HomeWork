﻿//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine ("Введите первое число: ");
int A=Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число: ");
int B=Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите третье число: ");
int C=Convert.ToInt32(Console.ReadLine());
int max=0;

if (A>B)
{
  max = A;
}
else
{
  max=B;
}

if (max<C)
{
  max=C;
}

 Console.WriteLine("MAX="+max);