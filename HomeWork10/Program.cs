/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

System.Console.WriteLine("Введите трёхзначное число: ");
String number = Convert.ToString(Console.ReadLine());
int len = number.Length;

if (len == 3)
{

System.Console.Write(number[1]);


} 
else{
   System.Console.Write(" Ошибка! Нужно трехзначное "); 
}

