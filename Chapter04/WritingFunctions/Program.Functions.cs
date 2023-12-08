using System.Formats.Asn1;
using System.Globalization;
partial class Program
{
    static void RunFibFunctional()
    {
        for (uint i = 1; i <= 30; i++)
        {
            WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
            arg0: CardinalToOrdinal(i),
            arg1: FibFunctional(term: i));
        }
    }
    static int FibFunctional(uint term) => term switch
    {
        0 => throw new ArgumentOutOfRangeException(),
        1 => 0,
        2 => 1,
        _ => FibFunctional(term - 1) + FibFunctional(term - 2),
    };
    static void RunFibImperative()
    {
        for(uint i = 1; i <= 30; i++)
        {
            WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
                arg0: CardinalToOrdinal(i),
                arg1: FibImperative(term: i));
        }
    }
    static int FibImperative(uint term)
    {
        if(term ==0)
        {
            throw new ArgumentOutOfRangeException();
        }
        else if (term == 1)
        {
            return 0;
        }
        else if (term == 2)
        {
            return 1;
        }
        else
        {
            return FibImperative(term-1)+FibImperative(term-2);
        }
    }
    static void RunFactorial()
    {
        for(int i = 0; i <= 15; i++)
        {
            try
            {
                WriteLine($"{i}!= {Factorial(i):N0}");
            }
            catch (OverflowException)
            {
                WriteLine($"{i}! is too big for a 32-bit integer.");
            }
            catch(Exception ex)
            {
                WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
            }
        }
    }
    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(message: $"The factorial function is defined for non-negative integers nonly. Input: {number}",
                paramName: nameof(number));
        }
        else if(number == 0)
        {
            return 1;
        }
        else
        {
            checked
            {
                return number * Factorial(number - 1);
            }
        }
    }
    static void RunCadinalToOrdinal()
    {
        for(uint number=1; number<=1500; number++)
        {
            Write($"{CardinalToOrdinal(number)} ");
        }
        WriteLine();
    }

    /// <summary>
    /// Truyền 32-bit không dấu và nó sẽ được chuyển đổi sang số thứ tự.
    /// </summary>
    /// <param name="number">Là số tự nhiên chẳng hạn 1,2,3,...</param>
    /// <returns>Số trả về là số thứ tự như 1st, 2nd, 3rd, ...</returns>
    static string CardinalToOrdinal(uint number)
    {
        uint lastTwoDigits = number % 100;
        switch (lastTwoDigits)
        {
            case 11 or 12 or 13:
                return $"{number:N0}th";
            default:
                uint lastDigit = number % 10;

                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number:N0}{suffix}";
        }
    }
    static void ConfigureConsole(string culture = "en-US", bool useComputerCulter = false)
    {
        OutputEncoding = System.Text.Encoding.UTF8;
        if (!useComputerCulter)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        WriteLine($"CurrentCulture: {CultureInfo.CurrentCulture}");
    }

    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08M,
            "DK" or "NO" => 0.25M,
            "GB" or "FR" => 0.2M,
            "HU" => 0.27M,
            "OR" or "AK" or "MT" => 0.0M,
            "ND" or "WI" or "ME" or "VA" => 0.05M,
            "CA" => 0.0825M,
            _ => 0.06M
        };
        return amount * rate;
    }

    #region TimesTable
    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times table with {size} rows: \n");

        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} x {number} = {row * number}");
        }
        WriteLine();
    }
    #endregion
}