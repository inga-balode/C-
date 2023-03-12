// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
void Gen2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int buf = array[j];
                array[j] = array[j + 1];
                array[j + 1] = buf;
            }
        }
}

void UpdateArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int [] arr = new int[matr.GetLength(1)];
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[j] = matr[i, j];
        }
        BubbleSort(arr);
        for (int k = 0; k < arr.Length; k++)
        {
            matr[i, k] = arr[k];
        }
    }
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];
Gen2DArray(matrix,1,100);
Print2DArray(matrix);
UpdateArray(matrix);
Print2DArray(matrix);