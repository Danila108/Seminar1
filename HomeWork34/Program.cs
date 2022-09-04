/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

 Console.Write("Введите колличество элементов в массиве: ");
 int [] numbers = new int[int.Parse(Console.ReadLine())];
 int min = 100;
 int max = 999;


void FillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);  //заполняет массив случайными числами
    Console.WriteLine(array[i]);
  }
}

int QuantityPositive(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)//проверяет на четность
    {
      quantity++;
    }
  }
  return quantity;  //возвращает колличество четных
}

FillArray(numbers, min, max);
int quantity = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");



















/*class Program
{
    static void Main()
    {
        Console.Write("Введите колличество элементов в массиве: ");
        String maxNumbers = Console.ReadLine();
        int series = Convert.ToInt32(maxNumbers);
        //Console.WriteLine(series);

        int[] array = new int[series];

        
        int min = 100;

       
        int max = 999;

              

        static int a (int [] array, int min, int max, int series)
        {
            Random rnd = new Random();  //Создание объекта для генерации чисел
            int ellemnt =0;
            for (int i = 0; i == series+1; i++)
            {
                //Получить случайное число (в диапазоне от min до max)
                int value = rnd.Next(min, max);
                array[i] = value;

                if (array[i] % 2 == 0 && i <= series){
                    ellemnt=ellemnt+1;
                    }
                    
              
            }
            Console.WriteLine(ellemnt);
            return ellemnt;
            
        }
         Console.WriteLine(a(array, min, max, series));
      
    }
  
         
}*/