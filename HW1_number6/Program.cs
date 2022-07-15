Console.WriteLine("Enter an integer");
int A = Convert.ToInt32(Console.ReadLine());
int remains = A % 2;
if (remains==0)
{
    Console.WriteLine(Convert.ToString(A)+ "- even number");
}
else
{
    Console.WriteLine(Convert.ToString(A)+ "- odd number");
}
