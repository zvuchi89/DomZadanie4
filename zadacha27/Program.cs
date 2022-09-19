// Задача 27: Напишите программу,
// которая принимает на вход число и выдаёт сумму цифр в числе.

int N, count = 0;	
	 Console.WriteLine("Введите  число " );	 
	 N = Convert.ToInt32(Console.ReadLine());
	  	  
	 while (N > 0)
    {
	 count += N % 10;
	 N /= 10;
	 }	
	Console.WriteLine("sum = " + count);
		
		
