// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
//*При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

double[,] GenDouble2DArr(int countRow, int countColumn, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    double[,] arr = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] =  rnd.Next(min, max + 1) + Math.Round(rnd.NextDouble(), 2);
        }
    }
    return arr;
}

void Print2DArr(double[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    int x = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {   
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr.GetLength(0) * arr.GetLength(1) <= 16)
            {
                Console.ForegroundColor = col[x];
                Console.Write($"{arr[i, j]} \t");
                Console.ResetColor();
                x++;
            }
            else 
            {
                // Находим разницу кол-ва элементов двумерного массива и кол-ва цветов, узнаем во сколько раз больше цветов нужно, округляем в большую сторону
                int diff = Math.Ceiling((arr.GetLength(0) * arr.GetLength(1) - col.Length)/col.Length);
                int total = diff * col.Length;
                int y = 0;
                ConsoleColor[] moreColors = new ConsoleColor[total];
                //Дублируем массив нужное кольво раз
                while (y <= diff);
                {
                    col.CopyTo(moreColors);
                    y++;
                }
                Console.ForegroundColor = col[x];
                Console.Write($"{arr[i, j]} \t");
                Console.ResetColor();
                x++;
            }
        }
        Console.WriteLine();
    }
}



int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
double[,] arr2D = GenDouble2DArr(row, column, 10, 99);
Print2DArr(arr2D);