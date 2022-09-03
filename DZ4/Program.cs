//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// void Func()
// {
//     Console.Write("Введите число A: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число B: ");
//     int b = Convert.ToInt32(Console.ReadLine());
//     int step = a;
//         for (int i = 1; i < b; i++)
//         {
//         step *= a;
//         }
//         Console.WriteLine($"A в степени B равно {step}");
// }
// Func();


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// void SumDigits()
// {
//     Console.WriteLine("Введите число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     int num = number;
//     int sum = 0;
//     	while (num > 0)
//     	{
//     	int res = num % 10;
//     	num /= 10;
//     	sum += res;
//     	}
//     Console.WriteLine($"Cумма всех цифр числа {number} равна {sum}");
// }

// SumDigits();


//Задача 29: Напишите программу, которая задаёт массив из произвольного количества элементов и выводит их на экран.

// int[] RandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 1000);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+",");
//     }
//     Console.Write("]");
// }

// Console.Write("Введите количество элементов в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());
// ShowArray(RandomArray(size));

