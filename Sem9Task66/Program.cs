// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int NumSumRec(int fromNum, int toNum)
{   
    int res = 0;
    if (fromNum >= toNum)
    {
        res = res + toNum;
    }
    else
    {
        res = res + fromNum + NumSumRec(fromNum + 1, toNum);
    }
    return res;
}


int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
int result = number1<number2?NumSumRec(number1, number2):NumSumRec(number2, number1);
Console.WriteLine(result);
