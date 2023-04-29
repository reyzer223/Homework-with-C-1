// Task 1#.

// int Prompt (string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int number = Prompt("inpit triple number:");
// if (number < 100 || number >= 1000)
// {
//     Console.WriteLine("not triple number");
//     return;
// }
// Console.WriteLine($"inputted number '{number}'");
// int secondRank = number / 10 % 10;
// Console.WriteLine($"Second number '{secondRank}'");~

// Task 2#.

// int Prompt (string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int GetThirdRank(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }
// bool ValidateNumber(int number)
// {
//     if(number < 100)
//     {
//         Console.WriteLine("third number not found");
//         return false;
//     }
//     return true;
// }
// int number = Prompt("Input number: ");
// if (ValidateNumber(number))
// {
//     Console.WriteLine(GetThirdRank(number));
// }

// Task 3#

// int Prompt (string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// bool isWeekend(int weekDay)
// {
//     if (weekDay > 5)
//     {
//         return true;
//     }
//     return false;
// }

// bool ValidateWeekDay(int number)
// {
//     if(number > 0 && number<=7)
//     {
//         return true;
//     }
//     Console.WriteLine("not week day");
//     return false;
// }

// int weekDay = Prompt ("input week day > ");
// if (ValidateWeekDay(weekDay))
// {
//     if (isWeekend(weekDay))
//     {
//         Console.WriteLine("Holidays");
//     }
//     else
//     {
//         Console.WriteLine("Weekend");
//     }
// }
