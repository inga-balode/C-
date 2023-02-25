// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return (int.Parse(Console.ReadLine() ?? "0"));
}

void PrintData(string output)
{
    Console.WriteLine(output);
}


long Counter(int x)
{
    long sum = 0;
    //int len = Convert.ToString(x).Length;
    int len = (int)Math.Log(x) + 1;
    for(int i=0; i <len ; i++ )
    {
        sum += x%10;
        x /= 10;
    }
    return sum;
}

long CounterString(int x)
{
    long sum = 0;
    string a = Convert.ToString(x);
    int len = a.Length;
    //char [] arr = a.ToCharArray(); можно было и в array перевести
    for(int i=0; i <len ; i++ )
    {
        sum += (int)Char.GetNumericValue(a[i]);
    }
    return sum;
}



int a = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
long result = Counter(a);
Console.WriteLine(DateTime.Now - d1);
PrintData($"Результат равен {result}");

DateTime d2 = DateTime.Now;
long resultString = CounterString(a);
Console.WriteLine(DateTime.Now - d2);
PrintData($"Результат равен {resultString}");