public enum PlayerPosition
{
    Goalkeeper,
    Defender,
    Midfielder,
    Forward
}

[System.Serializable]
public class Player
{
    public string Name;
    public PlayerPosition Position;
    public int Rating;

    public Player(string name, PlayerPosition position, int rating)
    {
        Name = name;
        Position = position;
        Rating = rating;
    }
}
