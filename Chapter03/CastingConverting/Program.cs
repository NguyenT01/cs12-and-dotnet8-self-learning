using static System.Convert;
using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;

int a = 10;
double b = a;
WriteLine($"a is {a}, b is {b}");

double c = 9.8;
int d = (int)c;
WriteLine($"c is {c}, d is {d}");

long e = 10;
int f = (int) e;
WriteLine($"e is {e:N0}, f is {f:N0}");

e = 5_000_000_000;
f = (int) e;
WriteLine($"e is {e:N0}, f is {f:N0}");

double g = 9.8;
int h = ToInt32(g);
WriteLine($"c is {g}, d is {h}");

double gg = 9.5543;
double gg2 = Math.Round(gg,0,MidpointRounding.AwayFromZero);
WriteLine(gg2);

#region Parse string to another type
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("vi-VN");

int friends = int.Parse("27");
DateTime birthday = DateTime.Parse("8 July 1997");
WriteLine($"I have {friends} friends to invite to my party.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");

#endregion

#region
Write("How many eggs are there? ");
string? input = ReadLine();

if(int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input.");
}

#endregion

#region Try-parse

bool isSuccess = int.TryParse("123", out int result1);

WriteLine($"{isSuccess} _ {result1}");

#endregion

