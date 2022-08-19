
// Вспомогательные методы: печать одномерного, двумерного массива, заполнение двумерного массива
void PrintArray(double[] numb1)
{
    Console.Write($"[");
    for (int i = 0; i < (numb1.Length - 1); i++)
    {
        Console.Write($"{numb1[i]}; ");
    }
    Console.Write($"{numb1[numb1.Length - 1]}]");
}
void PrintMatrixDouble(double[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++) { Console.Write($"{matrix[k, l]}  "); }
        Console.WriteLine();
    }
}
void PrintMatrixInt(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++) { Console.Write($"{matrix[k, l]}  "); }
        Console.WriteLine();
    }
}
int[,] FillingNewArrayInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++) { matrix[m, n] = new Random().Next(-10, 11); }
    }
    return matrix;

}


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] FillingNewArrayDouble(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) { matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 101)) / 10; }
    }
    return matrix;
}

//Задача 50. Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном массиве, 
// и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.

int[,] FindingPositionOfNumber(int[,] matrix, int Number)
{
    int a = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == Number)
            {
                a = a + 1;
            }
        }
    }
    int[,] ResultPosition = new int[a, 2];
    int b = -1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == Number)
            {
                b = b + 1;
                ResultPosition[b, 0] = i;
                ResultPosition[b, 1] = j;
            }
        }
    }
    return ResultPosition;
}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void ArithmeticMeanOfColumns(int[,] matrix)
{
    double[] MeanOfColumns = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            MeanOfColumns[j] = MeanOfColumns[j] + Convert.ToDouble(matrix[i, j]);
        }
        MeanOfColumns[j] = MeanOfColumns[j] / matrix.GetLength(0);
    }
    Console.WriteLine($"Среднее арифметическое столбцов массива:");
    PrintArray(MeanOfColumns);
}


// Тело программы Задача 47
Console.WriteLine($"Задача 47: Для заполнения массива вещественными числами введите его кол-во строк и столбцов");
int Row = Convert.ToInt32(Console.ReadLine());
int Column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[,] Array = FillingNewArrayDouble(Row, Column);
PrintMatrixDouble(Array);



// Тело программы Задача 50 
Console.WriteLine();
Console.WriteLine($"Задача 50: Введите число строк и столбцов для генерации нового массива");
int Row2 = Convert.ToInt32(Console.ReadLine());
int Column2 = Convert.ToInt32(Console.ReadLine());
int[,] Array2 = FillingNewArrayInt(Row2, Column2);
PrintMatrixInt(Array2);
Console.WriteLine($"Введите число, которое нужно найти в массиве");
int Number = Convert.ToInt32(Console.ReadLine());
int[,] Position = FindingPositionOfNumber(Array2, Number);

if (Position.Length==0) Console.WriteLine($"Искомого числа нет в массиве");
else 
{
    Console.WriteLine($"Индексы искомого числа/чисел:");
    PrintMatrixInt(Position);
}
Console.WriteLine($"Введите индекс для поиска числа в предыдущем массиве");
int Row3 = Convert.ToInt32(Console.ReadLine());
int Column3 = Convert.ToInt32(Console.ReadLine());

if (Row3 > Array2.GetLength(0) || Column3 > Array2.GetLength(0)) Console.WriteLine($"Данного элемента не существеут");
else Console.WriteLine($"Искомое число = {Array2[Row3,Column3]}");




// Тело программы Задача 52
Console.WriteLine();
Console.WriteLine($"Задача 52: Введите число строк и столбцов для генерации нового массива");
int Row4 = Convert.ToInt32(Console.ReadLine());
int Column4 = Convert.ToInt32(Console.ReadLine());
//int[,] Array3 = FillingNewArrayInt(Row3, Column3); //если нужны бы были целые числа (отрицательные в том числе)
int[,] Array3 = new int[Row4, Column4];
for (int i = 0; i < Array3.GetLength(0); i++)      //генерация положитеьных чисел
{
    for (int j = 0; j < Array3.GetLength(1); j++)
    {
        Array3[i, j] = new Random().Next(0, 11);
    }
}
Console.WriteLine($"Массив:");
PrintMatrixInt(Array3);
ArithmeticMeanOfColumns(Array3);

