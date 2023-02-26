// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//Преобразование ввода из консоли в числовое значение int
int ReadData(string msg)
{
    Console.Write(msg); return (int.Parse(Console.ReadLine() ?? "0"));
}

//Генерация массива со случяайными значениями заданной длины и диапазоном значений
int[] Gen1DArr(int len, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

//Печатает массив в терминале в виде [, , ,]
void Print1DArr(int[] arr)
{
    Console.Write("["); for (int i = 0; i < arr.Length - 1; i++) Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

//Подсчет суммы элементов, стоящих на нечётных позициях.
int CountOddIndSum(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        res += arr[i];
    }
    return res;
}

int len = ReadData("Введите длину массива:");
int a = ReadData("Обозначьте диапозон значений для заполнения. ОТ: ");
int b = ReadData("ДО:");
int[] arrRandom = Gen1DArr(len, a, b);
Print1DArr(arrRandom);
Console.WriteLine(CountOddIndSum(arrRandom));