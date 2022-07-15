Console.WriteLine("Enter a positive integer");
int A = Convert.ToInt32(Console.ReadLine());
int i=1;
while (i<A)
{
    int remains = i % 2;
    if (remains==0)
    {
         Console.Write(Convert.ToString(i)+" ");
    }
    i++;
}