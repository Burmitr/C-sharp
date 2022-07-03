// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите 5-значное число: ");
// string number = Console.ReadLine();

// if (number[0] == number[4] && number[1] == number[3])
// {
//     Console.WriteLine($"Число {number} - является палиндромом.");
// }
// else
// {
//     Console.WriteLine($"Число {number} - не палиндром.");
// }



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату X первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z первой точки: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату X второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z второй точки: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// // √((x2-x1)^2)+(y2-y1)^2+(z2-z1)^2
// double distance = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
// Console.WriteLine(distance);



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// for (int variable = 1; variable <= number; variable++)
// {
//     double current = Math.Pow(variable,3); 
//     Console.Write($"{current} ");
// }