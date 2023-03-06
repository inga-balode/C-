// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



// //Преобразование ввода из консоли в числовое значение int
// int ReadData(string msg)
// {
//     Console.Write(msg); return (int.Parse(Console.ReadLine() ?? "0"));
// }


// int FindPos (int m)
// {
//     int res = 0;
//     for(int i = 0; i < m; i++)
//     {
//         if(ReadData("")>0)
//         {
//             res++;
//         }
//     }
//     return res;
// }


// int len = ReadData("Введите длину массива:");
// Console.WriteLine("Пожалуйста, вводите числа, для разделения нажимая Enter");
// Console.WriteLine(FindPos(len));

// //Альтернативный вариант

// Console.WriteLine("Пожалуйста, вводите числа, для разделения нажимая Enter");

// int i=0;
// string a;
 
// //Получаем строку пока не будет команды end
// while ((a = Console.ReadLine()) != "end")
// {
//     if(int.Parse(a) > 0)
//     {
//         i++;
//     }
// }

// Console.WriteLine(i);


//Или просто метод
int FindPositive(string question)
{
    int i = 0;
    string a;
    Console.WriteLine(question);
    while ((a = Console.ReadLine()) != "end")
    {
        if(int.Parse(a) > 0)
        {
            i++;
        }
    }
    return i;
}

Console.WriteLine(FindPositive("Пожалуйста, вводите числа, для разделения нажимая Enter. Чтобы отановиться, напишите end"));
