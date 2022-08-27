
/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


System.Console.WriteLine("Введите 5-ти значное число: ");
String number = Convert.ToString(Console.ReadLine());
int len = number.Length;

void N1(string number)
{
    if (len != 5)
    { Console.WriteLine("Ошибка "); }
    else
    {

        if (number[0] == number[len - 1] && number[1] == number[len - 2])
        { Console.WriteLine("Полиндром  "); }
        else { System.Console.WriteLine("не полиндром"); }
    }
}

N1(number);


