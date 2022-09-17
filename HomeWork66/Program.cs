/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */


Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine());
int sum = 0;
if (M>N)
for (int i = N; i <= M; i++)
    sum = sum +i;
else
    for (int i = M; i <= N; i++)
        sum = sum +i;

Console.Write($" {sum}");
