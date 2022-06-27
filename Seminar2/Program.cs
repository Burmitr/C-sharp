//  Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

// int number = new Random().Next(10, 100); // (10,99)

// Console.WriteLine($"Случайное число - {number}"); // $ - интерполяция. Позволяет использовать текст и переменную в одной строке.

// int digitOne = number / 10; // 56 -> 5, 56/10=5
// int digitTwo = number % 10; // 56 -> 6

// Console.WriteLine(digitOne);
// Console.WriteLine(digitTwo);

// int max = Math.Max(digitOne, digitTwo);
// int min = Math.Min(digitOne, digitTwo);

// Console.WriteLine($"Максимальное значение числа - {number} = {max}");
// Console.WriteLine($"Минимальное значение числа - {number} = {min}");


// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(10, 1000);

// Console.WriteLine($"Рандомное число - {number}");

// int Result(int number)
// {
//     int first = number / 100;
//     int third = number % 10;
//     return first*10+third;
// }
// Console.Write(Result(number));



// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// int first = Convert.ToInt32(Console.ReadLine()); 
// int second = Convert.ToInt32(Console.ReadLine()); 

// if(first % second == 0)
// {
//     Console.WriteLine($"{first} кратно {second}");
// }
// else
// {
//     Console.WriteLine($"Не кратно. Остаток = {first % second}");
// }


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// int value = Convert.ToInt32(Console.ReadLine());

// bool IsMultiplicity (int number)
// {
//     return(number % 7 == 0 && number % 23 == 0);
// }
// Console.WriteLine(IsMultiplicity(value));