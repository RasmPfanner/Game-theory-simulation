using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour // monobehavior så det kan attaches til et GameObjekt
{
    private Game game;
    private List<Player> players;
    private PayoffMatrix matrix;
    private int currentRound;
    private int maxRounds;
}
