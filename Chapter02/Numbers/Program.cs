// Positive Int incl. 0
uint naturalNumber = 23;
// Original Int
int integerNumber = -23;
//float
float realNumber = 2.3f;
double anotherRealNumber = 2.3;

int largeNumber = 2_000_000;
double secondNumber = 1234.56789012;

Console.WriteLine($"{largeNumber:N0}");
Console.WriteLine($"{secondNumber:N2}");

Console.WriteLine($"int use {sizeof(int)} bytes and can store numbers in the " +
    $"range {int.MaxValue:N0} to {int.MinValue:N0}");

Console.WriteLine($"double use {sizeof(double)} bytes and can store number in the "+
    $"range {double.MinValue:N0} to {double.MaxValue:N0}");

Console.WriteLine($"decimal use {sizeof(decimal)} bytes and can store numbers in the " +
    $"range {decimal.MaxValue:N0} to {decimal.MinValue:N0}");

// COMPARE 2 DOUBLE AND DECIMAL TYPES
Console.WriteLine(new string ('-',count: 50));
Console.WriteLine("Using double:");
float a = 0.1F;
float b = 0.2F;
if(a+b == 0.3F)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equals {0.3}");
}

// RESOLVE THIS PROBLEM BY USING DECIMAL TYPE.
Console.WriteLine(new string('-', count: 50));
Console.WriteLine("Using decimal:");
decimal c = 0.1M;
decimal d = 0.2M;
if (c + d == 0.3M)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equals {0.3}");
}

// HALF AND INT128 AND UNSAFE CODE
Console.WriteLine(new string('-', count: 50));
unsafe
{
    Console.WriteLine($"Half use {sizeof(Half)} bytes and can store number in the " +
    $"range {Half.MinValue:N0} to {Half.MaxValue:N0}");
    Console.WriteLine($"Int128 use {sizeof(Int128)} bytes and can store number in the " +
        $"range {Int128.MinValue:N0} to {Int128.MaxValue:N0}");
}

