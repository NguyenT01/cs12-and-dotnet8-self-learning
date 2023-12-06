// See https://aka.ms/new-console-template for more information
// #error version
/*
WriteLine("Hello, World! ");

#region Three variables that store the number 2 million.

int deci = 2_000_000;
int bin = 0b_0001_1110_1000_0100_1000_0000;
int hexa = 0x_001e_8480;

#endregion

WriteLine($"{deci} {bin} {hexa}");

WriteLine($"Computer name {Env.MachineName} says \"No.\"");

WriteLine("Temperature on {0:D} is {1}C", DateTime.Today, 23.4);
*/

/*
using System.Reflection; //To use Assembly, TypeName, and so on.
System.Data.DataSet ds = new();
HttpClient client = new();

// Get the assembly that is the entry point for this app.
Assembly? myApp = Assembly.GetEntryAssembly();

// If the previous line return nothing then end the app.
if (myApp is null) return;

// Loop through the assemblies that my app references.
foreach(AssemblyName name in myApp.GetReferencedAssemblies())
{
    // Load the assembly so we can red its details
    Assembly a = Assembly.Load(name);

    // Declare a variable to count the number of methods.
    int methodCount = 0;

    //Loop through all the types in the assembly.
    foreach(TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Length;
    }

    //Output the count of tyoes and their methods.
    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name);
}
*/

double heightMetres = 1.88;
WriteLine($"The variable { nameof(heightMetres)} has the value { heightMetres} ");

char letter = 'A';
char digit = '1';
char sympol = '$';

string fname = "Bob";
string horizontalLine = new('-', count: 74);

OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1f600);
WriteLine(horizontalLine+ " "+grinningEmoji);

// VERBATIM STRINGS
string fnameWithTabSeparator = "Bob\tSmith";
string filePath = @"C:\televisions\sony\bravia.txt";

WriteLine(fnameWithTabSeparator);
WriteLine(filePath);

//RAW STRING
string xml = """
    <person age="50>
        <first_name> Mark </first_name>
    </person>
    """;

WriteLine(xml);


// RAW INTERPOLATED STRING LITERALS
var person = new {FirstName= "Alice", Age= 56};

string json = $$"""
        {
            "first_name": "{{person.FirstName}}",
            "age": {{person.Age}},
            calculation: "{{{1+2}}}",
        }
    """;

WriteLine(json);