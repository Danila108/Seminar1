/* Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */


Console.Write("Введи количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int number, int min, int max)
  {
  int[] randomNumbers = new int[number]; //пустой массив
  int[] massif = new int[number];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max); //заполнение массива ранд числами

      Console.Write(randomNumbers[i] + " "); //вывод
    }
    for (int i = 0; i<=number; i++){
      if (i <= number)
      {
        sumElements = randomNumbers[i] + randomNumbers[number - i];//
        massif[i] = sumElements;
        Console.WriteLine(massif[i]);
      }

    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(number, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");

