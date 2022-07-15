Console.WriteLine("enter the first number");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the second number");
double B = Convert.ToDouble(Console.ReadLine());
if (A>B)
{
    Console.WriteLine(Convert.ToString(A) +"- max");
}
else
{
    if (A==B)
    {
        Console.WriteLine(Convert.ToString(A)+ "="+ Convert.ToString(B));
    }
    else
    {
       Console.WriteLine(Convert.ToString(B)+"- max") ;
    }
}
