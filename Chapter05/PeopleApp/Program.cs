using Packt.Shared;
using Fruit = (string Name, int Number);

ConfigureConsole();

Person bob = new();

bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22,
    hour: 16, minute: 28, second: 0,
    offset: TimeSpan.FromHours(-5));    // US Eastern Standard Time

WriteLine(format: "{0} eas born on {1:D}", arg0: bob.Name, arg1: bob.Born);
WriteLine(bob);

// --- ALICE
Person alice = new()
{
    Name = "Alice Jones",
    Born = new DateTimeOffset(1988, 3, 7, 16, 28, 0, TimeSpan.Zero)
};

WriteLine(format: "{0} was born on {1:d}.", arg0: alice.Name, arg1: alice.Born);

// -- WONDER
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

WriteLine(
format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
arg0: bob.Name,
arg1: bob.FavoriteAncientWonder,
arg2: (int)bob.FavoriteAncientWonder);

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon
    | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");


// --- GENERICS
Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);

bob.Children.Add(new Person { Name = "Bella" });

bob.Children.Add(new() { Name = "Zoe" });

WriteLine($"{bob.Name} has {bob.Children.Count}");

for(int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}

// --- BANK ACCOUNT
BankAccount.InterestRate = 0.012M;

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs.Jones";
jonesAccount.Balance = 2400;

WriteLine(format: "{0} earned {1:C} interest.",
arg0: jonesAccount.AccountName,
arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;

WriteLine(format: "{0} earned {1:C} interest.",
arg0: gerrierAccount.AccountName,
arg1: gerrierAccount.Balance * BankAccount.InterestRate);

// ---
WriteLine($"{bob.Name} is a {Person.Species}.");
WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");

//---- BOOKS
/*
Book book = new()
{
    Isbn = "978-1803237800",
    Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
};
*/

Book book = new(isbn: "978-1803237800", title: "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals")
{
    Author = "Mark J. Price",
    PageCount = 821
};

WriteLine("{0}: {1} written by {2} has {3:N0} pages.", book.Isbn, book.Title, book.Author, book.PageCount);

// PERSON 2
Person blankPerson = new();
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated
);

// METHODS
bob.WriteToConsole();
WriteLine(bob.GetOrigin());

WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));

WriteLine(bob.OptionalParameters(3));
WriteLine(bob.OptionalParameters(3,"Jump!", 98.5));
WriteLine(bob.OptionalParameters(3, number: 52.7, command: "Hide!"));
WriteLine(bob.OptionalParameters(command: "Poke!", active: false, count:3));

// ADVANCED PARAMS
int a = 10;
int b = 20;
int c = 30;
int d = 40;

WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");

bob.PassingParameters(a, b, ref c, out d);

WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

// AP 2
int e = 50;
int f = 60;
int g = 70;

WriteLine($"Before: e={e}, f={f}, g={g}, h doesn't exist yet!");

bob.PassingParameters(e, f, ref g, out int h);

WriteLine($"After: e={e}, f={f}, g={g}, h={h}");

// TUPLES
(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2}");

Fruit fruitNamed = bob.getNamedFruit();
WriteLine($"{fruitNamed.Name}, {fruitNamed.Number}");

var thing1 = ("Neville", 4);
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
WriteLine($"{thing2.Name} has {thing2.Count} children.");

// DECONSTRUCT TUPLE
(string fruitName, int fruintNumber) = bob.GetFruit();
WriteLine($"Deconstructed tuple: {fruitName} , {fruintNumber}");

// DEVONSTRUCT + OUT KEYWORD
var (name1, dob1) = bob;
WriteLine($"Deconstructed person: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");

// LOCAL FUNCTIONS
int number = -1;
try
{
    WriteLine($"{number}! is {Person.Factorial(number)}");
}
catch(Exception ex)
{
    WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}");
}

//-------- GET,SET
Person sam = new()
{
    Name = "Sam",
    Born = new(1969, 6, 25, 0, 0, 0, TimeSpan.Zero)
};

WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");

string color = "Red";
try
{
    sam.FavoritePrimaryColor = color;
    WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");
}
catch(Exception ex)
{
    WriteLine("Tried to set {0} to '{1}': {2}", nameof(sam.FavoritePrimaryColor), color, ex.Message );
}

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.GreatPyramidOfGiza;

// INDEX
sam.Children.Add(new()
{
    Name = "Charlie",
    Born = new(2010, 3, 18, 0, 0, 0, TimeSpan.Zero)
});
sam.Children.Add(new()
{
    Name = "Ella",
    Born = new(2020, 12, 24, 0, 0, 0, TimeSpan.Zero)
});

WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}.");

WriteLine($"Sam's first child is {sam[0]}");
WriteLine($"Sam's second child is {sam[1].Name}.");

WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old");

// PATTERN MATCHING
WriteLine(new string('-', 50));

Passenger[] passengers =
{
    new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
    new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
    new BusinessClassPassenger { Name = "Janice" },
    new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave" },
    new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" }
};

foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        /*
         FirstClassPassenger p when p.AirMiles > 35_000 => 1_500M,
         FirstClassPassenger p when p.AirMiles > 15_000 => 1_750M,
         FirstClassPassenger _ => 2_000M,
         */
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35_000 => 1_500M,
            > 15_000 => 1_750M,
            _ => 2_000M
        }, 
        BusinessClassPassenger _ => 1_000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };

    WriteLine($"Flight cost {flightCost:C} for {passenger}");
}

// INIT
WriteLine(new string('-', 50));

ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Winger"
};

// jeff.FirstName = "Geoff";

// RECORD
ImmutableVehicle car = new()
{
    Brand = "Mazda MX-5 RF",
    Color = "Soul Red Crystal Metallic",
    Wheels = 4
};

ImmutableVehicle repaintedCar = car with { Color = "Polymental Grey Metallic" };
WriteLine($"Original car color was {car.Color}");
WriteLine($"New car color is {repaintedCar.Color}.");

// RECORD VS CLASS
AnimalClass ac1 = new() { Name = " Rex" };
AnimalClass ac2 = new() { Name = "Rex" };

WriteLine($"ac1 == ac2: {ac1 == ac2}");

AnimalRecord ar1 = new() { Name = "Rex" };
AnimalRecord ar2 = new() { Name = "Rex" };

WriteLine($"ar1 == ar2: {ar1 == ar2}");

// RECORD 2
WriteLine(new string('-', 50));

ImmutableAnimal oscar = new("Oscar", "Lebrador");
var (who, what) = oscar;
WriteLine($"{who}, is a {what}");

// PRIMARY CONSTRUCTOR
WriteLine(new string('-', 50));

Headset vp = new("Apple", "Vision Pro");
WriteLine($"{vp.ProductName} is made by {vp.Manufacturer}.");

Headset holo = new();
WriteLine($"{holo.ProductName} is made by {holo.Manufacturer}.");

Headset mq = new()
{
    Manufacturer = "Meta",
    ProductName = "Quest 3"
};
WriteLine($"{mq.ProductName} is made by {mq.Manufacturer}.");
