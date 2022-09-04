//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] RandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     int even = 0;
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+",");
//         if (array[i] % 2 == 0) even++;
//     }
//     Console.Write($"] чётных чисел в данном массиве -> {even}");
// }

// Console.Write("Введите количество элементов в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());
// ShowArray(RandomArray(size));


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] RandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     int sum = 0;
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+",");
//         if (i % 2 > 0) sum += array[i];
//     }
//     Console.Write($"] Сумма элементов нечётных позиций равна: {sum}");
// }

// Console.Write("Введите количество элементов в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение элементов в массиве: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение элементов в массиве: ");
// int max = Convert.ToInt32(Console.ReadLine());
// ShowArray(RandomArray(size, min, max));

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         void RealArray(double[] nums)
//         {
//             for (int i = 0; i < nums.Length; i++)
//             {
//                 nums[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
//             }
//         }

//         void ShowArray(double[] nums)
//         {
//             double max = int.MinValue;
//             double min = int.MaxValue;
//             Console.Write("[");
//             for (int i = 0; i < nums.Length; i++)
//             {
//                 Console.Write(nums[i] + " ");
//                 for (int j = 0; j < nums.Length; j++)
//                 {
//                     if (nums[j] > max)
//                     {
//                         max = nums[j];
//                     }
//                     if (nums[j] < min)
//                     {
//                         min = nums[j];
//                     }
//                 }
//             }

//             Console.Write($"] разница между максимальным и минимальным значением -> {max - min}");
//         }

//         Console.Write("Введите количество элементов в массиве: ");
//         int size = Convert.ToInt32(Console.ReadLine());
//         double[] nums = new double[size];
//         RealArray(nums);
//         ShowArray(nums);
//     }
// }

