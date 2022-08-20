/*Задача 4: Напишите программу, 
которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int MAX = 0;

if( number1 > number2)
{
    MAX=number1;
}

else
{
    MAX=number2;
}
if (MAX<number3){
    MAX=number3;
}
System.Console.Write("Максимальное число "+MAX);



