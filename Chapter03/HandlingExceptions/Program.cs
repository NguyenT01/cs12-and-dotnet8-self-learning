#region try-catch
WriteLine("Before parsing");Write("What is your age? ");string? input = ReadLine();try
{
    int age = int.Parse(input!);
    WriteLine($"You are {age} years old.");

}
catch (OverflowException)
{
    WriteLine("Your age is a valid number format but it is either too big or small.");
}
catch (FormatException) when (input!.Contains("$"))
{
    WriteLine("Amounts cannot use the dollar sign!");
}
catch (FormatException) 
{
    WriteLine("The age you entered is not a valid number format.");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} say {ex.Message}");
}
WriteLine("After parsing");
#endregion

#region OVERFLOW
unchecked
{
    int x = int.MaxValue - 1;
    WriteLine($"Initial value: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
}

int numMax = int.MaxValue;
int x5 = unchecked(numMax + 100);


#endregion