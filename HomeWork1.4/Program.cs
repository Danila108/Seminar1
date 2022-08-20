/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

System.Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int i =1;
while (i <= number1){
if( number1 >=i && i%2==0)
{
    System.Console.Write(i);
}
if( number1 !=i && i%2==0)
{
    System.Console.Write(", ");
}

i++;
}