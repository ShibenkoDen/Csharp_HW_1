// Задача 8. Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа от 1 до N

// итерация + 2

Console.Clear();

Console.WriteLine("Введите положительное число: ");
int number = int.Parse(Console.ReadLine()!);

int numberPrint = 2;
while (numberPrint <= number)
{
    Console.Write(numberPrint + " ");
    numberPrint = numberPrint + 2;
}
Console.WriteLine();