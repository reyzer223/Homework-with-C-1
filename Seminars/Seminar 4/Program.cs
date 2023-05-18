int DigitCount (int num)
{
    int count = 0;
    while (num  0)
    {
        count++;
        num/=10;
    }
    return count;
}

Console.WriteLine("Input Number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number of digits in{num} -> {DigitCount(num)}");