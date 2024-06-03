using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    private List<int> availableNumbers = new List<int>();

    private Dictionary<string, int> chessPieceNumbers = new Dictionary<string, int>
    {
        { "Pawn", 1 },
        { "Pawn2", 2 },
        { "Pawn3", 3 },
        { "Pawn4", 4 },
        { "Pawn5", 5 },
        { "Pawn6", 6 },
        { "Pawn7", 7 },
        { "Pawn8", 8 },
        { "LeftRook", 9 },
        { "LeftKnight", 10 },
        { "LeftBishop", 11 },
        { "King", 12 },
        { "Queen", 13 },
        { "RightBishop", 14 },
        { "RightKnight", 15 },
        { "RightRook", 16 }
    };

    public UnityEngine.UI.Text rollResultText;

    void Start()
    {
        InitializeAvailableNumbers();
       
    }

    void InitializeAvailableNumbers()
    {
        availableNumbers = new List<int>(chessPieceNumbers.Values);
    }

    public void RollDice()
    {
        int diceRoll = GetValidDiceRoll();
        Debug.Log("You rolled: " + diceRoll);

        if (rollResultText != null)
        {
            rollResultText.text = "You rolled: " + diceRoll;
        }
    }

    int GetValidDiceRoll()
    {
        if (availableNumbers.Count == 0)
        {
            Debug.LogError("No available numbers to roll!");
            return -1;
        }

        int randomIndex = Random.Range(0, availableNumbers.Count);
        return availableNumbers[randomIndex];
    }

    public void TakePiece(string pieceName)
    {
        if (chessPieceNumbers.TryGetValue(pieceName, out int number))
        {
            if (availableNumbers.Contains(number))
            {
                availableNumbers.Remove(number);
                Debug.Log(pieceName + " has been taken. Number " + number + " is now excluded.");
            }
        }
    }
    void OnMouseDown()
    {
        Debug.Log("2D object clicked.");
        RollDice();
    }
}
