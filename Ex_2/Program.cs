// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int m = int.Parse(Console.ReadLine());

int result = 0;
int sum = PrintDigits(n, m);
Console.WriteLine(sum);


int PrintDigits(int n, int m)
{


    if (m >= n)
    {
        result += m;
        m--;
        PrintDigits(n, m);
    }

    return result;
}