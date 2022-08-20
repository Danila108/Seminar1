// Программа принимает число возвращает квадрат
/*
Console.Write("Ввести число: ");
int number = Convert.ToInt32(Console.ReadLine());
int value = number * number;
Console.WriteLine("Ответ: " + value);
*/
/*
//является ли перво число квадратом второго
System.Console.Write("Первое число: ");
int squartNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Второе число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (squartNumber==(number*number))
{
    System.Console.WriteLine("Первое число квадрат второго: ");
    
}
else{
    Console.WriteLine("не квадрат");
}
*/


//Программа выдаёт день недели по номеру
System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if( number >=1 && number <= 7)
{
switch(number)
{
    case 1:
    System.Console.WriteLine("Monday");
    break;
    case 2:
    System.Console.WriteLine("вторник");
    break;
    case 3:
    System.Console.WriteLine("Среда");
    break;
    case 4:
    System.Console.WriteLine("Четверг");
    break;
    case 5:
    System.Console.WriteLine("Пятница");
    break;
    case 6:
    System.Console.WriteLine("Суббота");
    break;
    case 7:
    System.Console.WriteLine("Воскресенье");
    break;
    default: System.Console.WriteLine("неверный номер "); break;
}}
else{
    System.Console.WriteLine("Bad Number");
}