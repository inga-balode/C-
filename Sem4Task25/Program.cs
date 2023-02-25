// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

void PrintData(string output)
{
    Console.WriteLine(output);
}

long Pow(int a, int b)
{
    long res = 1;
    while (b >0)
    {
        res *= a;
        b -= 1;
    }

    return res;
}

//Решение с помощью встроенной функции
long PowFunc(double a, double b)
{
    return((long)Math.Pow(a, b));
}

int a = ReadData("Введите число: ");
int b = ReadData("В какую степень желаете возвести? ");
long result = Pow(a, b);
long resultFunc = PowFunc(a, b);
PrintData($"Результат равен {result}");
PrintData($"Результат равен {resultFunc}");