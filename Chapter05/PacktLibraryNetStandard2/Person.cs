namespace Packt.Shared;

public partial class Person :object {
    #region Fields: Data or state for this person.

    public string? Name;
    public DateTimeOffset Born;
    // public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();
    public const string Species = "Homo Sapiens";

    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    #endregion

    #region Constructors: Called when using new to instantiate a type.

    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    #endregion

    #region Methods: Actions the type can perform
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello!'";
    }

    public string SayHello(string name)
    {
        return $"{Name} says 'Hello, {name}!'";
    }

    public string OptionalParameters(int count,string command = "Run!", double number = 0.0, bool active = true)
    {
        return string.Format(
            format: "command is {0}, number is {1}, active is {2}",
            arg0: command,
            arg1: number,
            arg2: active);
    }

    public void PassingParameters(int w, in int x, ref int y, out int z)
    {
        z = 100;
        
        w++;
        //x++   // ERROR: Do x là read only trong method
        y++;
        z++;

        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
    }

    public (string, int) GetFruit()
    {
        return ("Apples",5);
    }

    public (string Name, int Number) getNamedFruit()
    {
        return (Name: "Apples", Number: 5);
    }

    public void Deconstruct(out string? name, out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }

    public void Deconstruct(out string? name, out DateTimeOffset dob, out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = Born;
        fav = FavoriteAncientWonder;
    }

    public static int Factorial(int number)
    {
        if(number < 0)
        {
            throw new ArgumentException(
                $"{nameof(number)} cannot be less than zero.");
        }
        return localFactorial(number);

        int localFactorial(int localNumber)
        {
            if (localNumber == 0) return 1;
            return localNumber * localFactorial(localNumber - 1);
        }
    }

    public Person this[int index]
    {
        get => Children[index];
        set
        {
            Children[index] = value;
        }
    }

    public Person this[string name]
    {
        get => Children.Find(p=> p.Name == name);
    }



    #endregion
}