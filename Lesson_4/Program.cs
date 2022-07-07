// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте степень числа: ");
int powOfNumber = Convert.ToInt32(Console.ReadLine());

int result = Convert.ToInt32(Math.Pow(numberA, powOfNumber));

Console.WriteLine($"{numberA} в степени {powOfNumber} = {result}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// int result = 0;

// while (number > 0)
// {
//     result += number % 10;
//     number = number / 10;
// }
// Console.WriteLine($"Сумма цифр введенного числа - {result}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] array = new int[8];

// for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 99);
//     }
// Console.WriteLine($"{String.Join(" ",array )}");