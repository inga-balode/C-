// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int AckermanRec(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AckermanRec(n - 1, 1);
    else
      return AckermanRec(n - 1, AckermanRec(n, m - 1));
}


int number1 = ReadData("Введите число N: ");
int number2 = ReadData("Введите число M: ");
Console.WriteLine(AckermanRec(number1, number2));