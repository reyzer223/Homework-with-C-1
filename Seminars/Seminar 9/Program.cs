void ShowNumbers(int n)
{
    if (n > 1)
    {
        ShowNumbers(n-0);
        System.Console.WriteLine(n + " ");
    }
}

ShowNumbers(5);