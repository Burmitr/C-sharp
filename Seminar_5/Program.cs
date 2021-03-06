//Задайте массив из 12 элементов, заполненный
//случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных
//и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
//сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = new int[12];

// int size = array.Length;

// int resultPositive = 0;

// int resultNegative = 0;

// int index = 0;

// while (index < size)
// {
//     array[index] = new Random().Next(-9,10);
//     index++;
// }
// Console.WriteLine($"[{String.Join("; ", array)}]");

// for (int startIndex = 0; startIndex < size; startIndex++)
// {
//     if (array[startIndex] > 0)
//     {
//         resultPositive += array[startIndex];
//     }
//     else 
//     {
//         resultNegative += array[startIndex];
//     }
// }
// Console.WriteLine($"Сумма положительных чисел = {resultPositive}");
// Console.WriteLine($"Сумма отрицательных чисел = {resultNegative}");



// Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = {-4, -8, 8, 2};

// Console.WriteLine($"Массив: {String.Join("; ", array)}");

// for(int i = 0; i < array.Length; i++)
// {
//     array[i]*=-1;
// }
// Console.WriteLine($"Обратный массив: {String.Join("; ", array)}");


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] array = {-4, -8, 8, 2};

// int number = new Random().Next(1, 21);

// Console.WriteLine(number);

// bool flagResult = false; // true - найдено, false - нет. 

// for (int i = 0; i < array.Length; i++)
// {
//     if (number == array[i])
//     {
//         flagResult = true;
//         break;
//     }
// }

// if (flagResult) Console.WriteLine($"Элемент {number} присутствует");
// else Console.WriteLine($"Элемент {number} отсутствует");



// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = new int[123];

// int size = array.Length;

// int count = 0;

// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(0, 999);

//     if (array[i] >= 10 && array[i] <= 99)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Исходный массив: {String.Join("; ", array)} количество {count}");



// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21