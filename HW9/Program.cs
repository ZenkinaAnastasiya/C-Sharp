//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
        else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

Console.WriteLine(AckermannFunction(3, 2));

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
int SumNumbers(int a, int b)
{
    if (b > a)
    {
        if (a != b) return SumNumbers(a + 1, b) + a;
        else return b;

    }
    else
    {
        if (b != a) return SumNumbers(a, b + 1) + b;
        else return b;
    }
}

Console.WriteLine(SumNumbers(1, 15));
//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
string PrintNumbers(int x, int y)
{
    if (x<y)
    {
        if (x <= y) return $"{x} " + PrintNumbers(x + 1, y);
        else return $"{x }";
    }
    else 
    {
        if (x > y) return PrintNumbers(x - 1, y)+$"{x} ";
        else return $"{y} ";
    }
}

Console.WriteLine(PrintNumbers(1,5));