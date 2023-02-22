// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

bool PaliTest (int num)
{
    bool res = false;
    if ((num/10000 == num%10)&& (num/1000%10 == num%100/10))
    {
        res = true;
    }
    return res;
}

int x = ReadData("Введите пятизначное число: ");
bool result = PaliTest(x);

if (result == true)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}

