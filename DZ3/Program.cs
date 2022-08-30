//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void PalindromNumber(string number)
// {
//   if (number[0]==number[4] || number[1]==number[3]) Console.WriteLine("Ваше число является палиндромом");
//   else Console.WriteLine("Ваше число не палиндром.");
// }

// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// if (number?.Length == 5) PalindromNumber(number);
// else Console.WriteLine("Для проверки введите пятизначное число");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Данную задачу я вообще не понял каким образом решать. Думал на следующем семинаре будет хоть решение с 2D, однако его не было.


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Cube(int n)
// {
//     int curr = 1;
//     while(curr<=n)
//     {
//         Console.Write(curr*curr*curr + ", ");
//         curr++;
//     }
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num <= 0) Console.Write("Некорректный ввод");
// else Cube(num);