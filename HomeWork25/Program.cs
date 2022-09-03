/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */


Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int rank = Convert.ToInt32(Console.ReadLine());

int Rank(int num, int rank){
    int answer =1;
  for (int i = 1; i <= rank; i++){
    answer = answer*num;
  }
  return answer;
}

int R = Rank(num, rank);
Console.Write(R);