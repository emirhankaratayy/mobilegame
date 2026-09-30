using System.Collections.Generic;

public class Team
{
    public string Name;
    public List<Player> Squad = new List<Player>();

    public Team(string name)
    {
        Name = name;
    }
}
