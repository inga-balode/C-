// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// *Заполнить числами Фиббоначи и выделить цветом найденную цифру


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
}

string posCheck(int[,] arr, int row, int col)
{
    string res = "";
    int match = 0;
    if (row >= 0 && row < arr.GetLength(0) && col >= 0 && col < arr.GetLength(1))
    {
        match = arr[row, col];
        res = $"Найден элемент {match}";
    }
    else
    {
        res = "Такого элемента нет";
    }
    return res;
}


int row = ReadData("Введите номер строки ");
int column = ReadData("Введите номер столбца ");
int[,] array = Gen2DArr(5, 8, 0, 99);
Console.WriteLine(posCheck(array, row, column));
