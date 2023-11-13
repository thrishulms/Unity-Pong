using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject Ball;

    [Header("Player 1")]
    public GameObject Player1;
    public GameObject Player1Goal;

    [Header("Player 2")]
    public GameObject Player2;
    public GameObject Player2Goal;

    [Header("Player Scores")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int player1Score;
    private int player2Score;   


    public void PlayerScored(bool isPlayer1)
    {
        if (isPlayer1)
        {
            Debug.Log("Player 1 Scored...");
            player1Score++;
            Player1Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
        } else
        {
            Debug.Log("Player 2 Scored...");
            player2Score++;
            Player2Text.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
        }

        ResetPositions();
    }

    public void ResetPositions()
    {
        Ball.GetComponent<Ball>().Reset();
        Player1.GetComponent<PlayerMovement>().Reset();
        Player2.GetComponent<PlayerMovement>().Reset();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
