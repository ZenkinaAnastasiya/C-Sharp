Console.WriteLine("Enter the first number");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second number");
double B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the third number");
double C = Convert.ToDouble(Console.ReadLine());
double max = A;
if (B>max)
{
    max=B;
}
if (C>max)
{
    max=C;
}
Console.WriteLine("Max=" + Convert.ToString(max));