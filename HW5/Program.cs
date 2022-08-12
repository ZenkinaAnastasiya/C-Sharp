void PrintArray (int [] numb1)
{
    Console.Write($"[");
     for (int index=0; index < (numb1.Length-1); index++ )
    {
        Console.Write($"{numb1[index]},");
    }
    Console.Write($"{numb1[numb1.Length-1]}]");
}

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int EvenNumbers (int [] numb2)
{
    int AmountEvenNumbers=0;
    for (int index=0; index < (numb2.Length); index++ )
    {
        if (numb2[index]%2==0) AmountEvenNumbers=AmountEvenNumbers+1;
    }
    return AmountEvenNumbers;
}

//Задача 36:Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int SumOddPsitions(int [] numb3)
{
    int Sum=0;
    for (int index=0; index < (numb3.Length); index++ )
    {
        if (index%2==1) Sum=Sum+numb3[index];
    }
    return Sum;
}

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int DifferenceBetweenMaxMin(int [] numb4)
{
    int max=numb4[0];
    int min=numb4[0];
    for (int index=0; index < (numb4.Length); index++ )
    {
        if (numb4[index]>max) max=numb4[index];
        if (numb4[index]<min) min=numb4[index];
    }
    return (max-min);
}


//проверка Задача 34

int [] numbers1 = new int [new Random().Next(5,11)];
for (int i=0; i < (numbers1.Length); i++ )
{
    numbers1[i]=new Random().Next(100,1000);
}
PrintArray(numbers1);
Console.WriteLine($" in the array the number of even = {EvenNumbers(numbers1)}");

// проверка Задача 36

int [] numbers2 = new int [new Random().Next(5,11)];
for (int i=0; i < (numbers2.Length); i++ )
{
    numbers2[i]=new Random().Next(-50,51);
}
PrintArray(numbers2);
Console.WriteLine($" sum of elements in odd positions = {SumOddPsitions(numbers2)}");

// проверка Задача 38

int [] numbers3 = new int [new Random().Next(5,11)];
for (int i=0; i < (numbers3.Length); i++ )
{
    numbers3[i]=new Random().Next(0,1001);
}
PrintArray(numbers3);
Console.WriteLine($" the difference between max and min = {DifferenceBetweenMaxMin(numbers3)}");



