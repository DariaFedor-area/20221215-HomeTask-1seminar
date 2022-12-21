// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Домашнее задание задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("задайте певое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("задайте второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
{
    Console.WriteLine($"max = {num1}, min = {num2}");
}
else
{
    Console.WriteLine($"max = {num2}, min = {num1}");
}
