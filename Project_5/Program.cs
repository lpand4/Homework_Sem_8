// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] InitMatrix(int m,int n)
{
    int[,] mtrx = new int[m,n];
    int value = 1;
    int i = 0, j=0;
    while(value <= m*n)
    {
        mtrx[i,j] = value;
        value++;

        //Вправо
        if (i <= j + 1 && i + j < n - 1)
            j++;
        //Вниз
        else if (i < j && i + j >= m - 1)
            i++;
        //Влево
        else if (i >= j && i + j > n - 1)
            j--;
        //Вверх
        else
            i--;    
    }

    return mtrx;
}
void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if(mtrx[i,j]<10)
                Console.Write($"0{mtrx[i,j]}   ");
            else 
                Console.Write($"{mtrx[i,j]}   ");
        }
        Console.WriteLine();
    }
}


int[,] matrix = InitMatrix(4,4);
PrintMatrix(matrix);