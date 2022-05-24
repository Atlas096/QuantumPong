using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    //Move speed for ball
    Vector3 movement = new Vector3(5, 3, 0);
    //Vector3 movement;
    //public GameObject handler;
    //BallHandler ballHandler;

    // Start is called before the first frame update
    void Start()
    {
        //movement = new Vector3(Random.Range(-5, 5), Random.Range(5, 9), 0);
        //ballHandler = handler.GetComponent<BallHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(ballHandler.isFirstGame)
        {
            //12 y 3 y
            //<0>0x
            Vector3 randomMove = new Vector3(Random.Range(-5, 5), Random.Range(3, 12), 0);
            ballHandler.isFirstGame = false;
        }
        else
        {
            transform.Translate(movement * Time.deltaTime);
        }*/
        transform.Translate(movement * Time.deltaTime);
    }

    bool getRandomBool()
    {
        bool value = (Random.value > 0.5f);
        return value;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "LimitTop" || collision.collider.name == "LimitBot")
        {
            movement.y = -movement.y;
        }

        if(collision.collider.name == "PlayerOne" || collision.collider.name == "PlayerTwo")
        {
            movement.x = -movement.x;
        }
    }

}
