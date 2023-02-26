// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// * Отсортировать массив методом пузырька
// * Отсортируйте массив методом подсчета

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


int CountOdd(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            res += 1;
        }
    }
    return res;
}


int len = ReadData("Введите длину массива:");
int a = ReadData("Обозначьте диапозон значений для заполнения. ОТ: "); //для универсальности метода не было задано значение, Для решения ввести от 100 до 1000
int b = ReadData("ДО:");
int[] arrRandom = Gen1DArr(len, a, b);
Print1DArr(arrRandom);
Console.WriteLine(CountOdd(arrRandom));


//Сортировка методом пузырька

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
DateTime d1 = DateTime.Now;
BubbleSort(arrRandom);
Console.WriteLine(DateTime.Now - d1);
Print1DArr(arrRandom);

//сортировка методом подсчета
void CountingSort(int[] arr)
{
    int max = arr.Max();
    int min = arr.Min();

    int[] count = new int[max - min + 1];
    int z = 0;
    for (int i = 0; i < count.Length; i++)
    {
        count[i] = 0;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        count[arr[i] - min]++;
    }

    for (int i = min; i <= max; i++)
    {
        while (count[i - min]-- > 0)
        {
            arr[z] = i;
            z++;
        }
    }
}

int[] arrRandom2 = Gen1DArr(len, a, b);
Print1DArr(arrRandom2);

DateTime d2 = DateTime.Now;
CountingSort(arrRandom2);
Console.WriteLine(DateTime.Now - d2);
Print1DArr(arrRandom2);