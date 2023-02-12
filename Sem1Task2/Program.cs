//Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите число: ");
//Считываем данные с консоли
string? x = Console.ReadLine();

Console.WriteLine("C чем хотите сравнить: ");
string? y = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (x != null && y != null)
{
    //Парсим введенные числа
    int num1 = int.Parse(x);
    int num2 = int.Parse(y);

    //Сравниваем
    if (num1 > num2)
    {
        Console.WriteLine("Число "+num1+" больше чем "+num2);
    }
    if (num1 < num2)
    {
        Console.WriteLine("Число "+num2+" больше чем "+num1);
    }
    else
    {
        Console.WriteLine("Числа равны");
    }
}

