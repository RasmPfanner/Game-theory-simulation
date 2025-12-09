using UnityEngine;

public class Player
{

    // Properties af Spiller

    public string Name { get; set; }
    public int id { get; set; }
    public Strategy CurrentStrategy { get; set; }
    public list<Strategy> AvailableStrategies { get; set; }

    public Player(string name, int playerId)
    {
        Name = name;
        id = playerId;
        AvailableStrategies = new list<Strategy>();
    }
}
