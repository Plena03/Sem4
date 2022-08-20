// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine ("Программа задает массив из 8 элементов и выводит их на экран.");

int[] CreateArray(){

int[] array = new int [8];
var random = new Random();

for (int i = 0; i< array.Length; i++) 
array[i] = random.Next(0,100);

return array;
}

var array = CreateArray();

Console.WriteLine("Сгенерировали массив из 8 элементов в диапазоне от [0, 100]:");

Console.Write("[");      
    for(var i = 0; i < array.Length; i++) 
    {         
        Console.Write(array[i]);                  
        if (i != array.Length - 1)             
        Console.Write(", ");     
        }          
Console.Write("]");     
Console.WriteLine();