/* Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */


Console.Write("Введи количество элементов массива: ");
int number = 4;//Convert.ToInt32(Console.ReadLine()); 
 Array Numbers(int number, int min, int max)
    {
    int[] randomNumbers = new int[number]; //пустой массив
    int[] massif = new int[number];
    int sumElements = 0;
    int revers = randomNumbers.Length -1;
    Console.Write("Получившийся массив: ");

    for (int i = 0; i < randomNumbers.Length-1 ; i++ ){
      randomNumbers[i] = new Random().Next(min, max); //заполнение массива ранд числами

      Console.Write(randomNumbers[i] + " "); //вывод
    }
    for (int i = 0; i<=revers; i++){
        sumElements=0;
        sumElements = randomNumbers[i] * randomNumbers[revers- i];//
        massif[i] = sumElements;
        Console.WriteLine(massif[i]);
      
    }
  return massif;
  }

Numbers(number, 1, 10);

Console.WriteLine($"\nСумма парных элементов: {Numbers}");

