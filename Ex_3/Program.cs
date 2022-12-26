// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int m = int.Parse(Console.ReadLine());

int result = Ackerman (n,m);

Console.WriteLine($"A ({n},{m}) = {result}");

int Ackerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0 && n != 0)
    {
        return Ackerman (n - 1, 1);
    }
    else
    {
        return Ackerman (n - 1, Ackerman (n, m - 1));
    }
}