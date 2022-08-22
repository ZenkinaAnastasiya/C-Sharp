void PrintMatrixInt(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++) { Console.Write($"{matrix[k, l]}  "); }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] FillingNewArrayInt()
{
    Console.WriteLine($"Для заполнения массива числами введите его кол-во строк и столбцов");
    int rows = Convert.ToInt32(Console.ReadLine());
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[rows, columns];
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++) { matrix[m, n] = new Random().Next(0, 10); }
    }
    Console.WriteLine();
    return matrix;
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

int[,] SortingRowsInDescending(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] > matrix[i, k])
                {
                    int storage = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = storage;
                }
            }
        }
    }
    return matrix;
}

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void MinimumRow(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] = sum[i] + matrix[i, j];
        }
    }
    int indexMinimumRow = 0;
    int sumMinimumRow = sum[0];
    for (int k = 1; k < matrix.GetLength(0); k++)
    {
        if (sum[k] < sumMinimumRow)
        {
            indexMinimumRow = k;
            sumMinimumRow = sum[k];
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {indexMinimumRow + 1}");
    Console.WriteLine();
}

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1))
    {
        int[,] resultMultiplication = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                resultMultiplication[i, j] = matrix1[i, j] * matrix2[i, j];
            }
        }
        Console.WriteLine($"Результат перемножения матриц:");
        PrintMatrixInt(resultMultiplication);
    }
    else Console.WriteLine($"Размеры матриц не соответствуют друг другу");
}

// Задача 62. Заполните спирально массив 4 на 4. 
void SpiralFilling()   //Универсальный метод для квадратных матриц
{   
    Console.WriteLine($"Введите сторону квадратной матрицы");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[n, n];

    //н.у.
    int i = 0; // исхдные индексы строки и столбца
    int j = -1;
    string direction = "left"; // направление заполнения матрицы
    int iTop = 0+1; //границы обхода
    int iDown = n-1;
    int jLeft = 0;
    int jRight = n-1;
    int number = 1; // присваеваемое число
    int countRuns = 0; //кол-во обходов по сторонам матрицы (сколько раз меняли направление обхода)

    while (countRuns < n * 2 - 1)
    {
        if (direction == "left")
        {
            while (j < jRight)
            {
                j = j + 1;
                array[i, j] = number;
                number = number + 1;
            }
            countRuns = countRuns + 1;
            jRight = jRight - 1;
            direction = "down";
        }
        if (direction == "down")
        {
            while (i < iDown)
            {
                i = i + 1;
                array[i, j] = number;
                number = number + 1;
            }
            countRuns = countRuns + 1;
            iDown = iDown - 1;
            direction = "right";
        }
        if (direction == "right")
        {
            while (j > jLeft)
            {
                j = j - 1;
                array[i, j] = number;
                number = number + 1;
            }
            countRuns = countRuns + 1;
            jLeft = jLeft + 1;
            direction = "top";
        }

        if (direction == "top")
        {
            while (i > iTop)
            {
                i = i - 1;
                array[i, j] = number;
                number = number + 1;
            }
            countRuns = countRuns + 1;
            iTop = iTop + 1;
            direction = "left";
        }
    }

    PrintMatrixInt(array);
}



Console.WriteLine($"Задача 54: сортировка строк по убыванию");  //по заданию ввод массива оттдельно от метода обработки массива
int[,] matrix1 = FillingNewArrayInt();          
PrintMatrixInt(SortingRowsInDescending(matrix1));

Console.WriteLine($"Задача 56: порядок минимальной по сумме строки");//по заданию ввод массива оттдельно от метода обработки массива
int[,] matrix2 = FillingNewArrayInt();              
PrintMatrixInt(SortingRowsInDescending(matrix2));
MinimumRow(matrix2);                                

Console.WriteLine($"Задача 58: перемножение матриц"); //по заданию ввод массивов оттдельно от метода обработки массивов
int[,] matrix3 = FillingNewArrayInt();              
int[,] matrix4 = FillingNewArrayInt();
PrintMatrixInt(matrix3);
PrintMatrixInt(matrix4);
MatrixMultiplication(matrix3, matrix4);

Console.WriteLine($"Задача 62: Заполнение матрицы по спирали"); //все промежуточные операции внутри метода согласно заданию
SpiralFilling();                          