/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

 Console.Write("Введите колличество элементов в массиве: ");
 int [] numbers = new int[int.Parse(Console.ReadLine())];
 int min = 1;
 int max = 1000;


void FillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);  //заполняет массив случайными числами
    Console.WriteLine(array[i]);
  }
}

int QuantityPositive(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (i % 2 != 0)//проверяет на  нечётность позиции
    {

      quantity= quantity + array[i];
    }
  }
  return quantity;  //возвращает сумму на нечетных позициях
}

FillArray(numbers, min, max);
int quantity = QuantityPositive(numbers);
Console.WriteLine($"Сумма на нечетных позициях: {quantity}");
