// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] InitMassive(int x, int y, int z)
{
    Dictionary<int, int> testDic = new Dictionary<int, int>();
    //int temp;
    Random rnd = new Random();
    int[,,] massive = new int[x,y,z];
    //
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                massive[i,j,k] = rnd.Next(10,100);
                while(testDic.ContainsKey(massive[i,j,k]))
                {                   
                    massive[i,j,k] = rnd.Next(10,100);
                }
                testDic.Add(massive[i,j,k],1);
            }
        }
    }
    return massive;
}

void PrintMassive(int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(2); i++)
    {
        for (int j = 0; j < mass.GetLength(0); j++)
        {
            for (int k = 0; k < mass.GetLength(1); k++)
            {
                Console.Write($"{mass[j,k,i]}({j},{k},{i}) ");   //Если чтобы вывод был как в примере, то так
            }
            Console.WriteLine();
        }
        
    }
}

Console.WriteLine("Введите 1 размер массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 размер массива: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 размер массива: ");
int z = Convert.ToInt32(Console.ReadLine());

if(x*y*z > 90)
Console.WriteLine("Размер массива слишком велик! Не существует более 90 неповторяющихся двузначных чисел.");
else
{
    int[,,] massive = InitMassive(x,y,z);
    PrintMassive(massive);
}