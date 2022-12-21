// Задача 2. Напишите программу, которая на вход принимает два числа 
// и выдает, какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
int max = 0;

if (number1 > number2)
{
    max = number1;
}
else max = number2;
Console.WriteLine($"Большее число равно {max}");