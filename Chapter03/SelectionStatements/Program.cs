
#region Dash Line
using System.Threading.Tasks.Dataflow;

void cc()
{
    WriteLine(new string('-', 50));
}
#endregion

#region password
string password = "ninja";

if(password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 chars");
}
else
{
    WriteLine("Your password is strong");
}
#endregion

cc();
#region pattern matching
object o = 3;
int j = 4;

if (j is int i)
{
    WriteLine($"{i} x {j} = {i * j}"); 
}
else
{
    WriteLine("o is not an int so it cannot multiply");
}

#endregion

cc();
#region Switch, break, goto, return 
int number = Random.Shared.Next(1, 7);
WriteLine($"Random number is {number}");

switch (number)
{
    case 1:
        WriteLine(1);
        break;
    case 2:
        WriteLine(2);
        goto case 1;
    case 3: // MULTIPLE CASE SECTION
    case 4:
        WriteLine("3 or 4");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
}

WriteLine("End of switch");
A_label:
WriteLine($"After A label");

#endregion

cc();
#region
var Animals = new Animal?[]
{
    new Cat{Name="Karen", Born = new(year:2022, month:8, day:23), Legs = 4, IsDomestic = true},
    null,
    new Cat{Name = "Mufasa", Born = new(1994,6,12)},
    new Spider{Name = "Sid Vicious", Born = DateTime.Today, IsPoisonous= true},
    new Spider{Name = "Captain Furry", Born = DateTime.Today}
};

foreach(Animal? animal in Animals)
{
    string message;

    switch (animal)
    {
        case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
            message = $"The cat named {fourLeggedCat.Name} has 4 legs";
            break;
        case Cat wildCat when wildCat.IsDomestic == false:
            message = $"The non-domestic cat is named {wildCat.Name}";
            break;
        case Cat cat:
            message = $"The cat is named {cat.Name}";
            break;
        default:    // default always evaluated last.
            message = $"{animal.Name} is a {animal.GetType().Name}";
            break;
        case Spider spider when spider.IsPoisonous:
            message = $"The {spider.Name} is poisonous. Run!";
            break;
        case null:
            message = "The animal is null";
            break;
    }
    WriteLine($"Switch statement: {message}");
}
#endregion

cc();
#region SWITCH EXPRESSION (SHORT-HAND SWITCH STATEMENTS)
foreach(Animal? animal in Animals)
{
    string message = animal switch
    {
        Cat fourLeggedCat when fourLeggedCat.Legs == 4 => $"The cat named {fourLeggedCat.Name} has four legs.",
        Cat wildCat when wildCat.IsDomestic == false => $"The non-domestic cat is named {wildCat.Name}.",
        Cat cat => $"The cat is named {cat.Name}.",
        Spider spider when spider.IsPoisonous => $"The {spider.Name} spider is poisonous. Run!",
        null => "The animal is null.",
        _ => $"{animal.Name} is a {animal.GetType().Name}.",
    };
    WriteLine($"Switch expression: {message}");
}

#endregion
