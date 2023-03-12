// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
// N = 5 -> "1, 2, 3, 3, 4"
// N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void LineNumRec(int num, int start)
{   
    Console.Write(start + " ");
    if (start == num)
    {
    }
    else
    {
        LineNumRec(num, start + 1);
    }
}

int startNum = 1;
int number = ReadData("Введите число N: ");
LineNumRec(number, startNum);
