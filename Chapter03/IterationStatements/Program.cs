
#region while
int x = 0;
while (x < 10)
{
    Write(x + " ");
    x++;
}

#endregion

#region do-while
string? actualPassword = "Pa$$w0rd";
string? password;

WriteLine();
do
{
    Write("Enter your password: ");
    password = ReadLine();
}
while (password != actualPassword);

WriteLine("Correct!");

#endregion

#region for
for(int y=1; y<=10; y++)
{
    Write(y+ " ");
}
WriteLine();
#endregion

#region foreach
string[] names = { "Adam", "Barry", "Charlie" };

foreach(string name in names)
{
    WriteLine($"{name} has {name.Length} chars");
}

#endregion

#region how foreach works
System.Collections.IEnumerator e = names.GetEnumerator();
while (e.MoveNext())
{
    string name = (string)e.Current;
    WriteLine($"{name} has {name.Length} characters.");
}
#endregion

