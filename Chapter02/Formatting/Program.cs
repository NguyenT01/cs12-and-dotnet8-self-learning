int numberOfApples = 12;
decimal pricePerApple = 0.35M;

OutputEncoding = System.Text.Encoding.UTF8;

WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

WriteLine(formatted);

// INTERPOLATED STRING
int x = 12;
float f = 3.14F;
string idea = $"PI is {f} with radius is {x}";
WriteLine(idea);

// FORMAT STRING
string applesText = "Apples";
int appleCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine();
WriteLine(format: "{0,-10} {1,6}", arg0: "Name", arg1: "Count");
WriteLine(format: "{0,-10} {1,6:N0}", arg0: applesText, arg1: appleCount);
WriteLine(format: "{0,-10} {1,6:N0}", arg0: bananasText, arg1: bananasCount);

WriteLine(new string('-', 50));
// GETTING TEXT INPUT
WriteLine("Type your first name and press ENTER: ");
string? firstName = ReadLine();

WriteLine("Type your age and press ENTER: ");
string age = ReadLine()!;

WriteLine($"{firstName} {age}");

WriteLine(new string('-', 50));
// GETTING KEY IMPORT FROM USER
Write("Press any key to continue: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}", arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);