// int[,] RowsToColumns(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         System.Console.WriteLine("Invalid input");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = i + 1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }
//     return array;
// }

// int[,] Create2DArray(int rows, int colums, int minVal, int maxVal)
// {
//     int[,] array2d = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array2d[i, j] = new Random().Next(minVal, maxVal + 1);
//         }
//     }
//     return array2d;
// }

// void PrintArray2d(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input colums");
// int colums = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("input minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, colums, minValue, maxValue);

// PrintArray2d(myArray);
// myArray = RowsToColumns(myArray);
// PrintArray2d(myArray);



//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2

// void Random2DArray(int[,] arg, int min, int max)
// {
//     for (int i = 0; i < arg.GetLength(0); i++)
//     {
//         for (int j = 0; j < arg.GetLength(1); j++)
//         {
//             arg[i, j] = new Random().Next(min, max + 1);
//         }
//     }
// }

// void Print2DArray(int[,] arg)
// {
//     for (int i = 0; i < arg.GetLength(0); i++)
//     {
//         for (int j = 0; j < arg.GetLength(1); j++)
//         {
//             Console.Write($" {arg[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[] Min_(int[,] arg)
// {
//     int min = arg[0, 0];
//     int[] cords = new int[2];
//     for (int i = 0; i < arg.GetLength(0); i++)
//     {
//         for (int j = 0; j < arg.GetLength(1); j++)
//         {
//             if (arg[i, j] < min)
//             {
//                 min = arg[i, j];
//                 cords[0] = i;
//                 cords[1] = j;
//             }
//         }
//     }

//     return cords;
// }
// void EditArray(int[,] arg, int[] cords)
// {
//     for (int i = 0; i < arg.GetLength(0); i++)
//     {
//         for (int j = 0; j < arg.GetLength(1); j++)
//         {
//             if (i == cords[0] || j == cords[1]) arg[i, j] = 0;
//         }
//     }
// }

// int[,] array = new int[5, 5];
// Random2DArray(array, 1, 9);
// Print2DArray(array);
// Console.WriteLine();
// EditArray(array, Min_(array));
// Print2DArray(array);

//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

// void Random2DArray(int[,] arg, int min, int max)
// {
//     for (int i = 0; i < arg.GetLength(0); i++)
//     {
//         for (int j = 0; j < arg.GetLength(1); j++)
//         {
//             arg[i, j] = new Random().Next(min, max + 1);
//         }
//     }
// }

// void Print2DArray(int[,] arg)
// {
//     for (int i = 0; i < arg.GetLength(0); i++)
//     {
//         for (int j = 0; j < arg.GetLength(1); j++)
//         {
//             Console.Write($" {arg[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void EditArray(int[,] arg, int row1, int row2)
// {
//     for (int i = 0; i < arg.GetLength(0); i++)
//     {
//         int temp = arg[row1 - 1, i];
//         arg[row1 - 1, i] = arg[row2 - 1, i];
//         arg[row2 - 1, i] = temp;
//     }
// }

// int[,] array = new int[5, 5];
// Random2DArray(array, 1, 9);
// Print2DArray(array);
// Console.WriteLine();
// EditArray(array, 2, 4);
// Print2DArray(array);