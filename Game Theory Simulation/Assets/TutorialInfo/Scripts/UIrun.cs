using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class UIrun : MonoBehaviour
{
    private void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        // referencer til IntegerFields i UI
        IntegerField Payoff1_1 = root.Q<IntegerField>("Payoff1_1");
        IntegerField Payoff2_1 = root.Q<IntegerField>("Payoff2_1");
        IntegerField Payoff1_2 = root.Q<IntegerField>("Payoff1_2");
        IntegerField Payoff2_2 = root.Q<IntegerField>("Payoff2_2");
        IntegerField Payoff1_3 = root.Q<IntegerField>("Payoff1_3");
        IntegerField Payoff2_3 = root.Q<IntegerField>("Payoff2_3");
        IntegerField Payoff1_4 = root.Q<IntegerField>("Payoff1_4");
        IntegerField Payoff2_4 = root.Q<IntegerField>("Payoff2_4");

        // referencer til button i UI
        Button ButtonConfirm = root.Q<Button>("ButtonConfirm");

        // Når Button bliver clicked kører OnConfirmButtonClicked
        ButtonConfirm.clicked += () => OnConfirmButtonClicked(
            Payoff1_1, Payoff2_1, Payoff1_2, Payoff2_2, Payoff1_3, Payoff2_3, Payoff1_4, Payoff2_4);
    }

    private void OnConfirmButtonClicked(
        IntegerField Payoff1_1,
        IntegerField Payoff2_1,
        IntegerField Payoff1_2,
        IntegerField Payoff2_2,
        IntegerField Payoff1_3,
        IntegerField Payoff2_3,
        IntegerField Payoff1_4,
        IntegerField Payoff2_4)
    {
        int payoff1_1 = Payoff1_1.value;
        int payoff2_1 = Payoff2_1.value;
        int payoff1_2 = Payoff1_2.value;
        int payoff2_2 = Payoff2_2.value;
        int payoff1_3 = Payoff1_3.value;
        int payoff2_3 = Payoff2_3.value;
        int payoff1_4 = Payoff1_4.value;
        int payoff2_4 = Payoff2_4.value;

        // Opret tuple med alle payoffs
        (int, int, int, int, int, int, int, int) payoffs =
            (payoff1_1, payoff2_1, payoff1_2, payoff2_2, payoff1_3, payoff2_3, payoff1_4, payoff2_4);

        // Skriv payoffs til konsollen når knappen er trykket
        PrintPayoffsToConsole(payoffs);
    }

    private void PrintPayoffsToConsole((int, int, int, int, int, int, int, int) payoffs)
    {
        Debug.Log("=== Payoff Matrix ===");
        Debug.Log($"(Cooperate, Cooperate): Player 1 = {payoffs.Item1}, Player 2 = {payoffs.Item2}");
        Debug.Log($"(Cooperate, Defect):    Player 1 = {payoffs.Item3}, Player 2 = {payoffs.Item4}");
        Debug.Log($"(Defect, Cooperate):    Player 1 = {payoffs.Item5}, Player 2 = {payoffs.Item6}");
        Debug.Log($"(Defect, Defect):       Player 1 = {payoffs.Item7}, Player 2 = {payoffs.Item8}");
    }
}