using UnityEngine;
using System.Collections.Generic;

public class Player
{

    // Properties af Spiller

    public string Name { get; set; }
    public int id { get; set; }
    public Strategy CurrentStrategy { get; set; }
    public List<Strategy> AvailableStrategies { get; set; }
    public int Score { get; set; }

    public Player(string name, int playerId)
    {
        Name = name;
        id = playerId;
        AvailableStrategies = new List<Strategy>();
        Score = 0;
    }
}
