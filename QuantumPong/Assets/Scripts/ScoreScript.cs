using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //Declares a variable that begins with the initial score and updates when OnTriggerEnter() is called
    int actualScore = 0;

    //Text Mesh in the canvas where score is shown
    public TextMeshProUGUI score;

    //Object ball to be instantiated when destroyed if game continues
    public GameObject ball;

    //Origin to instantiate the new ball
    Vector3 ballOrigin = new Vector3(0, 7.5f, 0);


    //Boolean to check if game continues or not
    bool isGameEnd = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {  

        //Check if score is 10 (that is the maximum) and if it's true the game will be check as finished
        if(actualScore == 10)
        {
            //End transition to new scene with scoreboard and win message
            isGameEnd = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        actualScore++;
        score.text = actualScore.ToString();
        Destroy(other.gameObject);
        if(!isGameEnd)
        {
            Instantiate(ball, ballOrigin, Quaternion.identity);
        }
    }
}
