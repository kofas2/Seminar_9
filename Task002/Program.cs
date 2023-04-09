// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(num));

string PrintNumbers(int num)
{
    if (num==1) return Convert.ToString(num + "");
    return PrintNumbers(num-1) + " " + num;
}
