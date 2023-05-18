// // // int DigitCount (int num)
// // // {
// // //     int count = 0;
// // //     while (num > 0)
// // //     {
// // //         count++;
// // //         num/=10;
// // //     }
// // //     return count;
// // // }

// // // Console.WriteLine("Input Number");
// // // int num = Convert.ToInt32(Console.ReadLine());

// // // Console.WriteLine($"Number of digits in{num} -> {DigitCount(num)}");

// // int [] CreateRandomArray (int size, int minValue, int maxValue)
// // {
// //     int[] newArray = new int[size];
// //     for (int i = 0; i < size; i++)
// //     {
// //         newArray[i] = new Random().Next(minValue, maxValue++);
// //     }
// //     return newArray;
// // }

// // void PrintArray(int[] array)
// // {
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         Console.Write(array[i] + " ");
// //     }
// //     Console.WriteLine();
// // }

// // Console.WriteLine("Input array size: ");
// // int size = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("input min value: ");
// // int minValue = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("input max value: ");
// // int maxValue = Convert.ToInt32(Console.ReadLine());

// // int[] myArray = CreateRandomArray(size, minValue, maxValue);

// // PrintArray(myArray);





// //Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// //4  -> 24
// //5  -> 120

// int Factorial (int N)
// {
//     int result = 1;
//     for (int i = 1; i <= N; i++)
//     {
//         result = result * i;
//     }
//     return result;
// }


// Console.WriteLine(Factorial(4));


// //Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int SumNum (int num)
// {
//     int A = 0;
//     for (int i = 0; i <= num; i++)
//     {
//         A += i;
//     }
//     return A;
// }

// Console.WriteLine(SumNum(5));