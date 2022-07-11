// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] inputArray = { 1, 2, 3, 4, 5 };
// int lastIndex = inputArray.Length - 1;

// int[] resultArray = new int[inputArray.Length / 2 + inputArray.Length % 2];

// for (int i = 0; i < resultArray.Length; i++)
// {
//     resultArray[i] = inputArray[i] * inputArray[lastIndex - 1];
//     if (i == lastIndex - i)
//     {
//         resultArray[i] = inputArray[i];
//     }
//     Console.Write($"{resultArray[i]} ");
// }



//Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] reversArray=ReverseCopyArray(array);
// Console.WriteLine(String.Join(" ", reversArray));

// ReverseArray(array);
// Console.WriteLine(String.Join(" ", array));

// int[] GetArray(int size, int minValue, int maxValue)
// {
// int[] res = new int[size];

// for (int i = 0; i < size; i++)
// {
//     res[i] = new Random().Next(minValue, maxValue + 1); // Next(0,11) -> [0;10]
// }
// return res;
// }

// void ReverseArray(int[] inArray)
// {
// for (int i = 0; i < inArray.Length / 2; i++)
// {
// int temp = inArray[i];
// inArray[i] = inArray[inArray.Length - i - 1];
// inArray[inArray.Length - i - 1] = temp;
// }
// }

// int[] ReverseCopyArray(int[] inArray)
// {
// int[] result = new int[inArray.Length];
// for (int i = 0; i < inArray.Length; i++)
// {
// result[i] = inArray[inArray.Length - 1 - i];

// }
// return result;
// }


// Работа в группах

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// проверяем - сумма двух сторон должна быть больше третьей.

// Console.WriteLine("Введите первое число");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());

// if(firstNumber + secondNumber > thirdNumber && firstNumber + thirdNumber > secondNumber && secondNumber + thirdNumber > firstNumber)
//     Console.WriteLine("Все ок");
// else  Console.WriteLine("нет");

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите до какого числа считать");
// int N = Convert.ToInt32(Console.ReadLine());

// int firstElement = 0;
// int secondElement = 1;
// Console.Write(firstElement + " " + secondElement + " ");

// for(int i = 3; i <= N; i++)
// {
//     int nextElement = firstElement + secondElement;
//     Console.Write(nextElement + " ");
//     firstElement = secondElement;
//     secondElement = nextElement;
// }


// Задача 42: Напишите программу,
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// void Binary(int number)
// {
//     string errorResult = "";
//     string result = "";
//     while (number > 0)
//     {
//         result = number % 2 + result;
//         errorResult = errorResult + number % 2;
//         number /= 2;
//     }
//     Console.WriteLine(result);
//     Console.WriteLine("Неправильный результат: " + errorResult);

// }

// int inputNumber = Convert.ToInt32(Console.ReadLine());
// Binary(inputNumber);



