// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Отсортируйте массив методом вставки

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

// Меняет два элемента массива местами
void Swap(int[] array, int i, int j)
{
    int buf = array[i];
    array[i] = array[j];
    array[j] = buf;
}

//Сортировка методом вставки
void InsertionSort(int[] array)
{
    int x;
    int j;
    for (int i = 1; i < array.Length; i++)
    {
        x = array[i];
        j = i;
        while (j > 0 && array[j - 1] > x)
        {
            Swap(array, j, j - 1);
            j --;
        }
        array[j] = x;
    }
}

int len = ReadData("Введите длину массива:");
int a = ReadData("Обозначьте диапозон значений для заполнения. ОТ: ");
int b = ReadData("ДО:");
int[] arrRandom = Gen1DArr(len, a, b);
Print1DArr(arrRandom);
InsertionSort(arrRandom);
Print1DArr(arrRandom);
Console.WriteLine(arrRandom[arrRandom.Length-1]- arrRandom[0]);