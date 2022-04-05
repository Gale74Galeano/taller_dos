using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TMP_Text curPlayerText;

    [SerializeField]
    Player[] players;

    public Player curPlayer;

    int curTurn;
    void Start()
    {
        curTurn = 1;
        if (players.Length > 1)
        {
            curPlayer = players[curTurn-1];
        }
        curPlayerText.text = "Player " + curTurn + " Turn";
    }

    public void EndTurn()
    {
        if(curTurn<players.Length)
        {
            curTurn += 1;
        }
        else if(curTurn >= players.Length)
        {
            curTurn = 1;
        }
        if (players.Length > 1)
        {
            curPlayer = players[curTurn - 1];
        }
        curPlayerText.text = "Player " + curTurn + " Turn";
    }
}
