// Task 1#.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// int userInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// void Polindrome()
// {
//     int number, temp, revNum = 0, rem;
//     Console.WriteLine("Enter the number:");
//     number = Convert.ToInt32(Console.ReadLine());
//     temp = number;
//     while(number>0)
//     {
//         rem = number % 10;
//         revNum = revNum * 10 +rem;
//         number = number / 10;
//     }
//     if (revNum == temp)
//     {
//     Console.WriteLine("Number is Polindrome");
//     }
//     else
//     {
//     Console.WriteLine("Number is not Polindrome");
//     }
//     Console.ReadLine();
// }
//     Polindrome();