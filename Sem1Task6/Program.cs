﻿// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите число: ");
//Считываем данные с консоли
int x = Convert.ToInt32(Console.ReadLine());

if (x % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Нечетное");
}