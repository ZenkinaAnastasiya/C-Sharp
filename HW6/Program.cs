void PrintArray (int [] numb1)
{
    Console.Write($"[");
     for (int index=0; index < (numb1.Length-1); index++ )
    {
        Console.Write($"{numb1[index]},");
    }
    Console.Write($"{numb1[numb1.Length-1]}]");
}
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int NumberPositive (int [] array)
{   
    int result=0;
    for (int i =0; i < array.Length; i++)
    {
        if (array[i]>0) result=result+1;
    }
    return result;
}

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b, a, d и c задаются пользователем.
void IntersectionLines(double a, double b, double c, double d)
{
    if (a==c) Console.WriteLine($"Straight parallel");
    else
    {
        double x = (d-b)/(a-c);
        double y = (b*c-a*d)/(c-a);
        Console.WriteLine($"Intersection point X={x} Y={y}");
    }
}


// проверка Задача 41
Console.WriteLine($"Enter the number of numbers in the array");
int [] numbers1 = new int [Convert.ToInt32(Console.ReadLine())];
Console.WriteLine($"Enter an array");
for (int i =0; i<numbers1.Length; i++)
{
    numbers1[i]=Convert.ToInt32(Console.ReadLine());
}
PrintArray(numbers1);
Console.WriteLine($" Number of positive numbers = {NumberPositive(numbers1)}");


// проверка Задача 43
Console.WriteLine($"Enter the coefficients k1, b1, k2, b2 for the equations y = k1 * x + b1; y = k2 * x + b2;");
int k1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
IntersectionLines(k1, b1, k2, b2);