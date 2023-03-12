//Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

//Метод перемножения матриц
int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            throw new Exception("Умножение невозможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }
        int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return matrixC;
    }

int m = ReadData("Введите количество строк для первой матрицы: ");
int n = ReadData("Введите количество столбцов для первой матрицы: ");
int k = ReadData("Введите количество строк для второй матрицы: ");
int l = ReadData("Введите количество столбцов для второй матрицы: ");
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[k, l];
Gen2DArray(matrix1,1,100);
Gen2DArray(matrix2,1,100);
Print2DArray(matrix1);
Print2DArray(matrix2);
Print2DArray(MatrixMultiplication(matrix1, matrix2));