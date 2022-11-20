// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] InitMatrix(int m,int n)
{
    Random rnd = new Random();
    int[,] mtrx = new int[m,n];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i,j] = rnd.Next(-10,11); 
        }
    }
    return mtrx;
}
void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[] SumOfRows(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    int sumOfRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumOfRow = sumOfRow + matrix[i,j];
        }
        sum[i] = sumOfRow;
        sumOfRow = 0;
    }
    return sum;
}

void MinSumRow(int[] sums)
{
    int min = sums[0];
    int minIndex = 0;
    for (int i = 0; i < sums.Length; i++)
    {
        if(sums[i] < min)
            {
            min = sums[i];
            minIndex = i;
            }   
    }
    Console.WriteLine($"Строка с минимальной суммой элементов - это {minIndex +1} строка");
}

Console.WriteLine("Введите кол-во строк матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = InitMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();
int[] sums = SumOfRows(matrix);
MinSumRow(sums);