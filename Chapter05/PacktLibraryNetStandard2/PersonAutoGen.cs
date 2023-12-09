namespace Packt.Shared;

public partial class Person
{
    #region Properties: Methods to get and/or set data or state
    public string Origin
    {
        get
        {
            return String.Format("{0} was born in {1}", arg0: Name, arg1: HomePlanet);
        }
    }

    public string Greeting => $"{Name} says 'Hello!'";
    public int Age => DateTime.Today.Year - Born.Year;

    public string? FavoriteIceCream { get; set; }
    private string? _favoritePrimaryColor;

    public string? FavoritePrimaryColor
    {
        get { return _favoritePrimaryColor; }
        set
        {
            switch (value?.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                    _favoritePrimaryColor = value;
                    break;
                default:
                    throw new ArgumentException(
                        $"{value} is not a primary color. " + "Choose from: red, green, blue.");
            }
        }
    }

    private WondersOfTheAncientWorld _favoriteAncientWonder;
    public WondersOfTheAncientWorld FavoriteAncientWonder
    {
        get => _favoriteAncientWonder;
        set
        {
            string wonderName = value.ToString();
            if (wonderName.Contains(','))
            {
                throw new ArgumentException(
                    message: "Favorite ancient wonder can only have a single enumvalue.",
                    paramName: nameof(FavoriteAncientWonder));
            }

            if(!Enum.IsDefined(typeof(WondersOfTheAncientWorld), value))
            {
                throw new ArgumentException(
                    $"{value} is not a member of the WondersOfTheAncientWorld enum",
                    paramName: nameof(FavoriteAncientWonder));
            }
            _favoriteAncientWonder = value;
        }
    }

    #endregion
}