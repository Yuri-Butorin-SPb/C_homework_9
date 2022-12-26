// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
PrintDigits(n);


void PrintDigits(int n)
{
    Console.Write(n + ", ");
    n--;
    if (n > i)
    {
        PrintDigits(n);
    }
    else if (n == i) Console.Write(n + ".");
    return;
}
