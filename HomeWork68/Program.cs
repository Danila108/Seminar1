/* Задача 68: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29 */

Console.Write("Введи n: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи m: ");
int m = Convert.ToInt16(Console.ReadLine());

int functionAkkerman = Aker(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Aker(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Aker(m - 1, 1);
  else return Aker(m - 1, Aker(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}


