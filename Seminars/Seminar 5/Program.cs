// //Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// // Найдите сумму отрицательных и положительных элементов массива.

// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue++);
//     }
//     return newArray;
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// // void PosNegSum (int[] array)
// // {
// //     int sumPos = 0;
// //     int sumNeg = 0;
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         if(array[i] >= 0) sumPos += array[i];
// //         else sumNeg += array[i];
// //     }
// //     System.Console.WriteLine($"Sum of positive elements -> {sumPos}, sum of negative elements -> {sumNeg} ");
// // }

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input min value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input max value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);
// myArray = invertArray(myArray);
// PrintArray(myArray);
// // PosNegSum(myArray);



// //Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int [] invertArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

