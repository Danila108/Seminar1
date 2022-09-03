/*
Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
пользователь вводит число элементов в массиве и минимальное, и максимальное значение . надо заполнить массив рандоными данными 
от минимального до максимального значение .И важное уточнениее , делать все в методе который возвращает массив
5, 1, 20 -> [1, 2, 5, 7, 19]

3, 1, 33 -> [6, 1, 33]*/


Console.Write("Введите размер массива: ");
String seriesOfNumbers = Console.ReadLine();
int series = Convert.ToInt32(seriesOfNumbers);
Console.WriteLine(series);

int[] array = new int[series];

Console.Write("Введите минимальное значение элемента: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элемента: ");
int max = int.Parse(Console.ReadLine());


   
Random rnd = new Random();  //Создание объекта для генерации чисел

for (int i = 0; i<= series; i++ ){
    //Получить случайное число (в диапазоне от min до max)
    int value = rnd.Next(min, max);
    array [i] = value;
    Console.WriteLine(array[i]);
}

    
    

