// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7 


Console.WriteLine("Введите число: ");
//Считываем данные с консоли
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Еще одно: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Еще давай: ");
int z = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[] {x, y, z};

//Проверим что все записалось в массив
//var str = string.Join(" ", arr);
//Console.WriteLine(str);

Console.WriteLine("Максимальное число: " + arr.Max());
