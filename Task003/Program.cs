﻿// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8


Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число A");
int b = Convert.ToInt32(Console.ReadLine());
if (a<b)
Console.WriteLine(PrintNumbers(a,b));
else 
    Console.WriteLine("Второе число должно быть больше первого");

string PrintNumbers(int a, int b)
{
    if (b==a) return Convert.ToString(a);
    return PrintNumbers(a,b-1) + " " + b;
}