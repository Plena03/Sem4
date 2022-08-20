// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16 

Console.WriteLine("Программа возводит число А в натуральную степень В.");

Console.WriteLine("Введите число A:");
var a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B:");
var b = int.Parse(Console.ReadLine()!);

long Degree (long num)
{   
    var result =(long) Math.Pow(a, b);
    return result;
}
var num = 1;

var result = Degree(num);//number

Console.WriteLine("Результат:" + result);