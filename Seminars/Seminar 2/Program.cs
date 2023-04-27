//Task #1.

// int MaxDigit(int RandomNumber)
// {
//     int dec = RandomNumber / 10;
//     int ed = RandomNumber % 10;
//     if(dec == ed)
//     Console.WriteLine("The number is polyndrome");
//     if(dec > ed) return dec;
//     else return ed;
// }

// int Number = new Random().Next(10, 99 + 1);

// int result = MaxDigit(Number);

// Console.WriteLine($"{Number} ->{result}");

//Task #2.

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// bool kratnost (int num1, int num2)
// {
//     if(num1 % num2 == 0) return true;
//     else return false;
// }

// Console.WriteLine("input first number:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num1}, {num2} -> {kratnost(num1, num2)}, ost {num1%num2}");

//Task 3# yourself

// bool kratnost (int num)
// {
//     if(num % 23 == 0 && num % 7 == 0) return true;
//     else return false;
// }

// Console.WriteLine("input first number:");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num} -> {kratnost(num)}");

//Task 4# yourself

// bool crat (int num1, int num2)
// {
//     if (num1 * num1 == num2 || num2 * num2 == num1) return true;
//     else return false;
// }
// Console.WriteLine("input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"quad {num1} {num2} {crat(num1, num2)} quad {num2} {num1} {crat(num2, num1)}");
