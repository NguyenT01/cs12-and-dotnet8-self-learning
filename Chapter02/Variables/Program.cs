using System.Xml;   // To use XML Document

object height = 1.88;
object name = "Amir";
Console.WriteLine($"{name} is {height} metres tall");
height = "asdasd";

// int length1 = name.Length;
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters");

Console.WriteLine(new string('-', 50));
//DYNAMIC TYPE
dynamic something;
something = new[] { 3, 5, 7 };
something = 12;
something = "Ahmed";
Console.WriteLine($"The length of something is {something.Length}");
Console.WriteLine($"something is a {something.GetType()}");

Console.WriteLine(new string('-', 50));
// LOCAL VAR
var population = 67_000_000;
var weight = 1.88;
var price = 4.99M;
var fruit = "Apples";
var letter = 'Z';
var happy = true;

//
long num1 = 100L;
ulong num2 = 200UL;
decimal num3 = 30.45M;
double num4 = -40.01D;
float num5 = -55.123F;
//

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

//TARGET-TYPE NEW TO INSTANTIATE OBJECTS
XmlDocument xml3 = new();   // Equivalent to "new XmlDocument();"

// 1/ TRADITIONAL WAY
Person user1 = new Person();

// 2/ VAR
var user2 = new Person();

// 3/ TARGET-TYPE NEW
Person kim = new();

kim.BirthDate = new(1967, 12, 26);

//LIST
List<Person> people = new()
{
    new() {fn= "Alice"},
    new() {fn="Bob"}
};


Console.WriteLine(new string('-', 50));
// DEFAULT VALUE
Console.WriteLine($"default int = {default(int)}");
Console.WriteLine($"default int = {default(bool)}");
Console.WriteLine($"default int = {default(DateTime)}");
Console.WriteLine($"default int = {default(string)}");

int number = 13;
Console.WriteLine($"number set to {number}");
number = default;
Console.WriteLine($"number reset to its default {number}");




class Person
{
    public DateTime BirthDate;
    public string fn;
}