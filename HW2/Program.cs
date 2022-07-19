// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int SecondDigitOfNumber(int Number1)
{
    int SecondDigit = (Number1%100-Number1%10)/10;
    return SecondDigit;
}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
int ThirdDigitOfNumber(int Number2)
{
   string C = Convert.ToString(Number2);
   int Length= C.Length;
   int ThirdDigit=-1;
   if (Length>=3)
   {
        ThirdDigit = Number2 % Convert.ToInt32(Math.Pow(10.0,Convert.ToDouble(Length-2)))/Convert.ToInt32(Math.Pow(10.0,Convert.ToDouble(Length-3)));
   }
    return ThirdDigit;
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
bool Weekend (int Number3)
{
if (Number3==6 || Number3==7)
{
    return true;
}
else
{
    return false;
}
}


// проверка Задача 10
int numb = new Random().Next(100,1000);
int digit = SecondDigitOfNumber (numb);
Console.WriteLine ($"the second digit of the number {numb} is {digit}");

// проверка Задача 13
int N = new Random().Next(0,1000000000);
int A = ThirdDigitOfNumber(N);
Console.WriteLine ($"the third digit of the number {N} is {A} ");

// проверка Задача 15
int Day = new Random().Next(0,10);
bool Answer = Weekend (Day);
Console.WriteLine ($"Is {Day} day weekend?  Answer {Answer}");
