//Задача 29: Напишите программу, 
//которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[]array = new int[n];
for (int i = 0; i < array.Length; i++)
 array [i] = new Random().Next(0, n);

 Console.WriteLine("[" + string.Join(",", array)+"]");