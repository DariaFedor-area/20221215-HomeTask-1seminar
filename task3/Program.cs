// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/* Домашнее задание задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.Clear();
Console.WriteLine("Задайте число");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"Заданное число - {num} - четное");
}
else
{
    Console.WriteLine($"Заданное число - {num} - нечетное");
}

