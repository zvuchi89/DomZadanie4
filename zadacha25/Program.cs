// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
long a = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите число B: ");
long b = Convert.ToInt64(Console.ReadLine());

{
    long result = 1;
    for (long i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

