/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

System.Console.WriteLine("Введите xисло: ");
String number = Convert.ToString(Console.ReadLine());
int len = number.Length;

if (len >2){
    
    System.Console.Write(number[2]);
    }
else{
   System.Console.Write(" Ошибка! Нет третьего числа ");
}