using UnityEngine;
using System.Collections.Generic;

public class PayoffMatrix
{
    private Dictionary<(Strategy, Strategy), (int, int)> Outcomes;

    public PayoffMatrix()
    {
        Outcomes = new Dictionary<(Strategy, Strategy), (int, int)>(); // Initialiserer dictionary der holder strategi-udfald
    }

    public void SetOutcome(Strategy strategy1, Strategy strategy2, int payoff1, int payoff2)
    {
        Outcomes[(strategy1, strategy2)] = (payoff1, payoff2); // Gemmer outcome når spillerne har valgt en strategi


        // Finder payoff for givet strategikombination
        var key = (strategy1, strategy2);
        Outcomes[key] = (payoff1, payoff2);
    }

    public (int, int) GetPayoffs(Strategy strategy1, Strategy strategy2)
    {
        var key = (strategy1, strategy2);

        if (Outcomes.ContainsKey(key))
        {
            return Outcomes[key]; // Returnerer payoff for de valgte strategier
        }
        else
        {
            Debug.LogError("Outcome not defined for the given strategies."); // Retunerer fejl hvis udfaldet ikke er defineret
            return (0, 0);
        }
    }

    public void DisplayMatrix (List<Strategy> strategies)
    {
        // Print payoff matrix til konsollen
        foreach (var strategy1 in strategies)
        {
            string row = strategy1.Name + ": ";
            foreach (var strategy2 in strategies)
            {
                var payoffs = GetPayoffs(strategy1, strategy2);
                row += $"({payoffs.Item1}, {payoffs.Item2}) ";
            }
            Debug.Log(row);
        }
    }

}