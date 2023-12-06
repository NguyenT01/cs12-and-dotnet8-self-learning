WriteLine($"There are {args.Length} arguments");

if(args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size, e.g. ");
    WriteLine("dotnet run red yellow 50");
    return;
}

foreach(string arg in args)
{
    WriteLine(arg);
}

ForegroundColor = (ConsoleColor) Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0], ignoreCase: true);

BackgroundColor = (ConsoleColor) Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1], ignoreCase: true);

try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("The current platform does not support changing the size of the cursor");
}

if (OperatingSystem.IsWindows())
{
    WriteLine("This is Windows");
}
else if (OperatingSystem.IsWindowsVersionAtLeast(10))
{
    WriteLine("Windows 10+");
}
else if (OperatingSystem.IsBrowser())
{
    WriteLine("Web Blazor");
}

#if NET8_0_OR_GREATER
    WriteLine("NET 8");
#elif NET7_0_OR_GREATER
    WriteLine("Net 7");
#else
    WriteLine("Do Nothing");
#endif