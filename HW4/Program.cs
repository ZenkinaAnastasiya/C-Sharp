// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponent (int numb1, int numb2)
{
    int result = 1;
    if (numb2 == 0)
    {
        result = 1;
    }
    else
    {
            for (int i = 0; i<numb2; i++)
        {
            result = result * numb1;
        }
    } 

    return result;
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNumber (int numb3)
{
    int result =0;
   
    for (int i =1; i<numb3+1; i=i*10)
    {
        result = result + (numb3%(i*10)/i);
    }
    return result;
}

// Задача 29: (необязательная) Напишите программу, которая создает массив из введенных через запятую цифр и выводит этот массив на экран.

void StrToArreyInt(string STR)
{   bool separator = true;
    int counter = -1;
    int [] array = new int [STR.Length];
    
    for (int index =0; index < STR.Length; index++)
    {   
        if (STR[index]==',' || STR[index]==' ')
        {
            separator = true;
        }
            
        else
        {
            if (separator == true)
            {   
                counter=counter+1; 
                array [counter] = Convert.ToInt32(STR[index])-'0'; 
                
                
            }
            else
            {
                array [counter] = array[counter] * 10 + (Convert.ToInt32(STR[index])-'0'); 
                
            }
            separator = false;
        }
        
    }
    
    Console.WriteLine();
    int i=0;
     while (i<counter+1 )
    {
        Console.WriteLine(array[i]);
        i++;
    }
}


// проверка Задача 25
int A=2;
int B=4;
Console.WriteLine ($"{A} в степени {B} = {Exponent (A,B)}");
Console.WriteLine();

// проверка Задача 27
int C=9012;
Console.WriteLine ($"Сумма цифр числа {C} = {SumNumber (C)}");
Console.WriteLine();

// проверка Задача 29
Console.WriteLine($"Введите массив чисел через запятую или пробел");
string string1= Console.ReadLine();
StrToArreyInt(string1);