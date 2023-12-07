
#region Cross Line
void cc()
{
    WriteLine(new string('-', 50));
}
#endregion

#region Exploring unray operator
int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");

#endregion

#region ++x
int c = 3;
int d = ++c;
WriteLine($"c is {c}, d is {d}");

#endregion

#region double value
// int e = 11;
int f = 3;
double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");

#endregion

cc();
#region Null-coalescing operators
string? authorName = ReadLine();

// if authorName is nulll it will be assign 30, otherwise it will be its length.
int maxLength = authorName?.Length ?? 30;

// authorName will be "unknown" if authorName was null.
authorName ??= "unknown";

WriteLine($"{maxLength} , {authorName}");
WriteLine(authorName == null);

#endregion

cc();
#region CONDIATIONAL LOGICAL OPERATORS
bool p = true;
bool q = false;
static bool DoStuff()
{
    WriteLine("I am doing some stuff");
    return true;
}

WriteLine($"p & DoStuff {p && DoStuff()}");
WriteLine($"q & DoStuff {q && DoStuff()}");


#endregion

cc();
#region Miscellaneous operators
int age = 50;
WriteLine($"The {nameof(age)} variable uses {sizeof(int)} butes of memory");

char firstDigit = age.ToString()[0];
WriteLine($"--> {firstDigit}");
#endregion


