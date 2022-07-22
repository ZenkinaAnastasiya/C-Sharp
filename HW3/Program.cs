// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Palindrome(int number)
{
    int digit1 = number /10000;
    int digit2 = number % 10000/ 1000;
    int digit4 = number % 100/ 10;
    int digit5 = number % 10/ 1;
    
    if (digit1==digit5 && digit2==digit4) return true;
    else return false;
}

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double LengthSegment(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    double Length = Math.Sqrt(Math.Pow(X1-X2, 2) + Math.Pow(Y1-Y2, 2) + Math.Pow(Z1-Z2, 2));
    return Length;
}

//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cubes (int count)
{
    int i=1;
    while (i<=count)
    {
       Console.WriteLine($"{i}^3={Math.Pow(Convert.ToDouble(i), 3)}"); 
       i++;
    }
}


// проверка Задача 19

Console.WriteLine ($"Enter a five-digit number");
int numb = Convert.ToInt32 (Console.ReadLine ());
bool Answer = Palindrome (numb);
Console.WriteLine ($"The number {numb} is a palindrome? Answer: {Answer}");
Console.WriteLine();

// проверка Задача 19

Console.WriteLine($"Enter the coordinates of the first and second points");
double A1 = Convert.ToDouble (Console.ReadLine ());
double B1 = Convert.ToDouble (Console.ReadLine ());
double C1 = Convert.ToDouble (Console.ReadLine ());
double A2 = Convert.ToDouble (Console.ReadLine ());
double B2 = Convert.ToDouble (Console.ReadLine ());
double C2 = Convert.ToDouble (Console.ReadLine ());
Console. WriteLine($"The length of the segment between the points is equal to {LengthSegment(A1,B1,C1,A2,B2,C2)}");
Console.WriteLine();

// проверка Задача 23

Console.WriteLine($"Enter the number of cubes to view");
int NumberOfCubes = Convert.ToInt32 (Console.ReadLine ());
Cubes (NumberOfCubes);