// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] InitMatrix(int m,int n)
{
    Random rnd = new Random();
    int[,] mtrx = new int[m,n];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i,j] = rnd.Next(0,5); 
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
            Console.Write($"{mtrx[i,j]}   ");
        }
        Console.WriteLine();
    }
}


int[,] MultMatrix(int[,] matrixA, int[,] matrixB)
{
    int sum = 0;
    int[,] resultMatrix = new int[matrixA.GetLength(0),matrixB.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(0); k++)
            {
                sum = sum + matrixA[i,k] * matrixB[k,j];
            }
            resultMatrix[i,j] = sum;
            sum = 0;
        }
    }
    return resultMatrix;
}

Console.WriteLine("Введите кол-во строк 1 матрицы: ");
int mA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов 1 матрицы: ");
int nA = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = InitMatrix(mA,nA);

Console.WriteLine("Введите кол-во строк 2 матрицы: ");
int mB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов 2 матрицы: ");
int nB = Convert.ToInt32(Console.ReadLine());
int[,] matrixB = InitMatrix(mB,nB);

PrintMatrix(matrixA);
Console.WriteLine("---------------------");
PrintMatrix(matrixB);
Console.WriteLine("---------------------");
if(matrixA.GetLength(1)!=matrixB.GetLength(0))
{
    Console.WriteLine("Произведение матриц возможно только в том случае, когда количество столбцов 1-ой равно количеству строк 2-ой");
}
else
{
int[,] resultMatrix = MultMatrix(matrixA,matrixB);
PrintMatrix(resultMatrix);
}

