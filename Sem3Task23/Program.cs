// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

string LineBuilder(int n, int power)
{
    string res = String.Empty;
    for(int i = 1; i<=n; i++)
    {
        res = res + Math.Pow(i,power)+"\t";
    }
    return res;
}

int x = ReadData("Введите конечное число: ");
Console.WriteLine(LineBuilder(x,1));
Console.WriteLine(LineBuilder(x,3));