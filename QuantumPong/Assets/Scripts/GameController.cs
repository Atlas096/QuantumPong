using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject playerTwo;
    
    // Start is called before the first frame update
    void Awake()
    {
        if(MenuController.versusComputer == true)
        {
            playerTwo.GetComponent<PlayerScript>().enabled = false;
            playerTwo.GetComponent<AIScript>().enabled = true;
        }
    }
}
