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

//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// int [] CreateArray (int size)
// {
// int [] array = new int [size];
// for (int i =0; i < size; i++)
// {
// Console.Write($"Введите число элемента массива {i} ");
// array[i] = Convert.ToInt32(Console.ReadLine());
// }
// return array;
// }

// bool NumFind(int num, int[] array)
// {
// for(int i = 0; i< array.Length; i++)
// {
// if(array[i] == num) return true;
// }
// return false;
// }

//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//значения которых лежат в отрезке [10,99].

//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

// int NumFind2(int[] array)
// {
// int count = 0;
// for(int i = 0; i< array.Length; i++)
// {
// if(array[i] <= 99 && array[i] > 10) count++;
// }
// return count;
// }

// int [] myArray = CreateRandomArray(12,1,150);

// PrintArray(myArray);
// Console.WriteLine(NumFind2(myArray));