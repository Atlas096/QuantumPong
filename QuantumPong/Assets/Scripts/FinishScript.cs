using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    int playerOne = ScoreScript.playerOneScore;
    int playerTwo = ScoreScript.playerTwoScore;
    public TextMeshProUGUI winnerMessage;
    public TextMeshProUGUI scoreOne;
    public TextMeshProUGUI scoreTwo;

    string oneWinner = "PLAYER ONE WINS";
    string twoWinner = "PLAYER TWO WINS";

    void Start()
    {
        if(playerOne > playerTwo)
        {
            winnerMessage.text = oneWinner;
        }
        else
        {
            winnerMessage.text = twoWinner;
        }
        scoreOne.text = playerOne.ToString();
        scoreTwo.text = playerTwo.ToString();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene (sceneName:"Main Menu");
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
