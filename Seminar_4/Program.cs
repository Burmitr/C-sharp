// int[] array = { 1, 2, 3, 4, 5 };

// //вывод массива с конвертацией из int в string
// Console.WriteLine($"{String.Join("; ", array)}");



// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int A = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// for (int i =1; i <= A; i++)
// {
//     sum += i; // sum = sum + i 
// }
// Console.WriteLine(sum);



// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int number = Convert.ToInt32(Console.ReadLine());

// int count = 0;

// while (number != 0)
// {
//     number /= 10;
//     // number = number / 10
//     count++;
// }
// Console.WriteLine(count);



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
// Произведение чисел от 1 до N = Факториал N = N!

// int N = Convert.ToInt32(Console.ReadLine());

// int result = 1;

// for (int i = 1; i <= N; i++)
// {
//     result*=i;
// }
// Console.Write(result);



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int [] array = GetBinaryArray(8);
// Console.WriteLine($"[{String.Join("; ",array )}]");

// int [] GetBinaryArray(int size)
// {
//     int [] resultArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         resultArray[i] = new Random().Next(2);
//     }
//     return resultArray;
// }