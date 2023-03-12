// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Печать трехмерного массива
void Print3DArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Заполнение трехмерного массива случайными числами
void Gen3DArray(int[,,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }
}


int m = ReadData("Введите величину X для массива формата XxYxZ: ");
int n = ReadData("Введите величину Y для массива формата XxYxZ: ");
int k = ReadData("Введите величину Z для массива формата XxYxZ: ");
int[,,] arr = new int[m, n, k];
Gen3DArray(arr, 1, 100);
Print3DArray(arr);