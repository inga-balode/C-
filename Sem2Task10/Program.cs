//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.WriteLine("Введите тречзначное число:" ?? "0");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((num%100)/10);