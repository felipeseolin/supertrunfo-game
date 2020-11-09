using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class GameController : MonoBehaviour 
{
    public GameObject sortearPanel;
    public GameObject roundPanel;
    public Text roundText;
    public Text scoreText;
    public ARController camera;

    public int numRounds = 5;

    private int playerOneScore = 0;
    private int playerTwoScore = 0;
    private int round = 1;

    private GameObject playerOneCard;
    private GameObject playerTwoCard;
    private void Start()
    {
        newRound();
        
    }

    private void Update()
    {
    }

    private void newRound()
    {
        roundText.text = "Round " + round;
        scoreText.text = "(Player 1) " + playerOneScore + " X " + playerTwoScore + " (Player 2)";
        if (round > 5)
        {
            playerTwoScore++;
            roundText.text = "Player 2 venceu";
            roundPanel.SetActive(true);
            return;
        }
        roundPanel.SetActive(true);
        Invoke("desativarPainel", 5);

        if (round % 2 == 0)
        {
            playerOneScore++;
        } else
        {
            playerTwoScore++;
        }

        round++;

        Invoke("newRound", 20);
    }

    private void desativarPainel()
    {
        roundPanel.SetActive(false);
    }
}
