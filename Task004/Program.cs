// Задача 67: Напишите программу, 
// которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр введенного числа {SumNumbers(a)}");

int SumNumbers(int a)
{
    if (a==0) return 0;
    return a%10 + SumNumbers(a/10);
}
