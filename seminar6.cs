// напишите программу которая перевернет одновременно массив
// элем-ы двумерного массива задаются случайнр и лежат в промежутке от -10 до 10

// int [] FillArray(int capacity)
// {   
//     int [] array = new int[capacity];

//     for (int i = 0; i < array.Length; i++)
    
//     {
//         array[i] = new Random().Next(-10, 10);
//         Console.Write(array [i] + " ");
//     }
//     return array;        
// }

// void  arrayReverse(int [] array)
// {
//     int size = array.Length;

//     for (int i = 0; i < size / 2; i++)
//     {
//        int temp = array[i];
//        array[i] = array[size - i - 1];
//        array[size - i - 1]= temp;
//     }
// }

// int [] arr = FillArray(10);
// Console.WriteLine();
// arrayReverse (arr);

// foreach (int item in arr)
// {
//     Console.Write(item + " ");
// }


// Вычислить среднее арифметическое положительных элементов в массиве 
// Элем-ы двумер массива задаются случайно и лежат в промежутке от -10 до 10



// int [] FillArray(int capacity)
// {   
//     int [] array = new int[capacity];

//     for (int i = 0; i < array.Length; i++)
    
//     {
//         array[i] = new Random().Next(-10, 10);
//         Console.Write(array [i] + " ");
//     }
//     return array;        
// }

// void  arrayReverse(int [] array)
// {
//     int size = array.Length;

//     for (int i = 0; i < size / 2; i++)
//     {
//        int temp = array[i];
//        array[i] = array[size - i - 1];
//        array[size - i - 1]= temp;
//     }
// }

// int [] arr = FillArray(10);
// Console.WriteLine();
// arrayReverse (arr);

// foreach (int item in arr)
// {
//     Console.Write(item + " ");
// }

// double sum = 0;
// int count = 0;

// foreach (int item in arr)
// {
//     if (item > 0)
//     {
//         sum +=item;
//         count++;
//     }

// }


// Console.WriteLine( " сумма " + sum);
// Console.WriteLine( " среднее арифметическое " + sum/count);

// ------------------------------------------------------------------------------------------------
// ДОМАШНЕЕ ЗАДАНИЕ

//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



// Console.Write (" Введите элементы через пробел: ");
// int [] M = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

// int count = 0;

// for (int i = 0; i < M.Length; i++)
// {
//     if (M[i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Кол-во элементов больше 0: {count}");


// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());

// int x = (b1 - b2) / (k1 - k2);
// int y = k1 * x + b1;

 
// Console.WriteLine($"Пересечение в точке: ({x};{y})");
