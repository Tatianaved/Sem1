// Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.


// Console.WriteLine("Введите значение M:");
//     int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите значение N:");
//     int n = int.Parse(Console.ReadLine());

//     ShowNumbers(m, n);
    
// static void ShowNumbers(int start, int end)
//     {
//         if (start == end + 1) // Базовый случай: когда текущее число превышает конечное значение
//             return;

//         Console.Write(start + " "); // Выводим текущее число с пробелом
//         ShowNumbers(start + 1, end); // Рекурсивно вызываем функцию для следующего числа
//     }

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.WriteLine("Введите значение m:");
//     int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите значение n:");
//     int n = int.Parse(Console.ReadLine());

//     int result = AckermannFunction(m, n);
// Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен {result}");

// static int AckermannFunction(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return AckermannFunction(m - 1, 1);
//         }
//         else
//         {
//             return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//         }
//     }

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// Задаем произвольный массив
// int[] array = { 1, 2, 3, 4, 5 };

//         // Вызываем рекурсивную функцию для вывода элементов массива, начиная с конца
// PrintArrayReverse(array, array.Length - 1);
    

// static void PrintArrayReverse(int[] array, int index)
//     {
//         // Базовый случай: когда индекс становится меньше 0, прекращаем рекурсию
//     if (index < 0)
//             return;

//         // Выводим текущий элемент массива
//     Console.WriteLine(array[index]);

//         // Рекурсивно вызываем функцию для следующего элемента массива с уменьшением индекса
//         PrintArrayReverse(array, index - 1);
//     }