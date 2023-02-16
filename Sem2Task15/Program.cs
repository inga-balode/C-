//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Write("Введите день недели: ");
int day = int.Parse(Console.ReadLine());

string[] dayWeek = new string[7];
    dayWeek[0] = "Понедельник";
    dayWeek[1] = "Вторник";
    dayWeek[2] = "Среда";
    dayWeek[3] = "Четверг";
    dayWeek[4] = "Пятница";
    dayWeek[5] = "Суббота";
    dayWeek[6] = "Воскресенье";  

//<переменная> = (условие)?<значение1>:<значение2>;
string result = ((day-1) == 5 || (day-1) == 6)?result = "это выходной":result = "ещё рабочая неделя";

Console.WriteLine(result);
