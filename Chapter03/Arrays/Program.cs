
#region Cross Line
void cc()
{
    WriteLine(new string('-', 50));
}
#endregion

#region 1d array
string[] names;

names = new string[4];

names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";

// ALTERNATIVE WAY
string[] names2 = { "Kate", "Jack", "Rebecca", "Tom" };

for(int i=0; i< names.Length; i++)
{
    WriteLine($"{names[i]} is at pos {i}");
}
#endregion

#region multi-dimension array
string[,] grid1 =
{
    {"Alpha", "Beta", "Gamma", "Delta" },
    { "Anne", "Ben", "Charlie", "Doug" },
    { "Aardvark", "Bear", "Cat", "Dog" }
};

WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
WriteLine($"2nd dimension, upper bound: {grid1.GetUpperBound(1)}");

for(int row=0; row<= grid1.GetUpperBound(0); row++)
{
    for(int col=0; col<= grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
    }
}
#endregion

cc();
#region jagged array
string[][] jagged =
{
    new[]{ "Alpha", "Beta", "Gamma" },
    new[]{ "Anne", "Ben", "Charlie", "Doug" },
    new[]{ "Aardvark", "Bear" }
};

for(int row = 0; row <= jagged.GetUpperBound(0); row++)
{
    for(int col =0; col<= jagged[row].GetUpperBound(0);col++)
    {
        WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");

    }
}

#endregion