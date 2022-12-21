// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Clear();
Console.WriteLine("нужно певое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("нужно второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("нужно третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num2 > num3)
    {
    Console.WriteLine($"max = {num1}");
    }
    else 
    {
        Console.WriteLine($"max = {num3}");
    }
}
else if (num2 > num3)
{
    Console.WriteLine($"max = {num2}");
}
else 
{
    Console.WriteLine($"max = {num3}");
}

Console.WriteLine("ну вот и всё, конец!");

