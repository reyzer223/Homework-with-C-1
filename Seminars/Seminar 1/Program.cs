// Console.WriteLine("input number:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"You input {{{number}}} number");

// for comment use (ctrl + /) надо выделить

//task 1. Запросить число вывести его квадрат

// Console.WriteLine("input number:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"square of number {number} = {number*number}");

//task 2. Является ли 1 число квадратом второго

Console.WriteLine("input first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second number:");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 == number2*number2)
{
     Console.WriteLine($"{number1} is square of {number2}");
}
else
{
    Console.WriteLine($"{number1} is not square of {number2}");
}
