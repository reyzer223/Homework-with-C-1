// Task 1#

// int FindQuart(int x, int y)
// {
//     if (x < 0 && y > 0) return 1;
//     if (x > 0 && y < 0) return 2;
//     if (x < 0 && y > 0) return 3;
//     if (x > 0 && y < 0) return 4;

//     return 0;
// }

// Console.WriteLine ("input X:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("input Y:");
// int y = Convert.ToInt32(Console.ReadLine());

// int result = FindQuart(x, y);
// Console.WriteLine($"Point with {x} && {y} coordinates located at {result} quart");

// Task 2#

// double FindDistance(double xa, double ya, double xb, double yb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)),2);
// }

// Console.WriteLine("Input coordinate X to A:");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y to A:");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate X to B:");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y to B:");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between point A with coordinates ({xa},{ya}) and point B with coordinates({xb},{yb}) ->{FindDistance(xa,ya,xb,yb)}");

// Task 3#

// int userInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// void FindQuart(int x)
// {
//     if (x==1) Console.WriteLine("x < 0 && y > 0");
//     if (x==2) Console.WriteLine("x > 0 && y < 0");
//     if (x==3) Console.WriteLine("x < 0 && y > 0");
//     if (x==4) Console.WriteLine("x > 0 && y < 0");

//     else Console.WriteLine("invalid number");
// }

// int x = userInput("input x:");
// FindQuart(x);

// Task 4#

// void QuadN(int N)
// {
//     int count = 1;
//     while(count<N)
//     {
//         Console.WriteLine($"{count} -> {count*count}");
//         count++;
//     }
// }
// int N = userInput("Input N:");
// QuadN(N);