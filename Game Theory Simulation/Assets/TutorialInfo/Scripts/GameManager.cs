using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour // monobehavior så det kan attaches til et GameObjekt
{
    private Game game;
    private List<Player> players;
    private PayoffMatrix matrix;
    private int currentRound;
    private int maxRounds;


    // UI fields for payoff matrix

    // spiller 1
    private int s1_s1_p1;
    private int s1_s2_p1;
    private int s2_s1_p1;
    private int s2_s2_p1;

    // spiller 2
    private int s1_s1_p2;
    private int s1_s2_p2;
    private int s2_s1_p2;
    private int s2_s2_p2;
}

