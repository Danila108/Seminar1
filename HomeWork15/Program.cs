/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

** Дополнительное не обезательное *****

Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да */

System.Console.WriteLine("Введите цифру ДН: ");
int  number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7){
    switch (number){
        case 6: System.Console.Write(" Выходной ");break;
        case 7: System.Console.Write(" Выходной ");break;
        default: System.Console.Write(" Будний"); break;
    }  
    }
else{
   System.Console.Write(" Ошибка! Нет такого дня недели ");
}

/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да */
/*
System.Console.WriteLine("Введите число: ");
int  number = Convert.ToInt32(Console.ReadLine());

if (number %7 == 0 && number % 23 == 0){
    
      System.Console.Write(" кратно одновременно 7 и 23 ");
    }
else{
   System.Console.Write(" не кратно одновременно 7 и 23 "); }
   */