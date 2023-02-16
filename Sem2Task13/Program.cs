//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else if (num >=100 && num < 1000)
{
    Console.WriteLine(num % 10);
}
else if (num >= 1000){
    while (num >= 1000)
    {
        num /= 10;
    }
    Console.WriteLine(num % 10);
}
else
{
    Console.WriteLine("невалидное число");
}

