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



Console.Write (" Введите элементы через пробел: ");
