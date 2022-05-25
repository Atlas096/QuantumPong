using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    //Move speed for ball
    Vector3 movement;

    float speed = 1;
    
    int directionX;
    int directionY;

    bool isNew = true;
    
    GameObject ballHandler;
    GameObject soundManager;
    BallHandlerScript ballHandlerScript;
    SoundScript soundScript;

    // Start is called before the first frame update
    void Start()
    {
        ballHandler = GameObject.Find("BallHandlerObject");
        ballHandlerScript = ballHandler.GetComponent<BallHandlerScript>();
        soundManager = GameObject.Find("SoundManager");
        soundScript = soundManager.GetComponent<SoundScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if(ballHandlerScript.isFirstGame)
        {
            directionX = getDirectionX();
            directionY = getDirectionY();
            movement = new Vector3(directionX, directionY, 0);
            ballHandlerScript.isFirstGame = false;
        }
        else
        {
            if(isNew)
            {
                if(ballHandlerScript.rightScore)
                {
                    directionX = 5;
                    directionY = getDirectionY();

                    movement = new Vector3(directionX, directionY, 0);
                }
                if(ballHandlerScript.leftScore)
                {                    
                    directionX = -5;
                    directionY = getDirectionY();
                    movement = new Vector3(directionX, directionY, 0);
                }
                isNew = false;
            }
            
        }

        transform.Translate(movement * speed * Time.deltaTime);
    }
    
    bool getRandomBool()
    {
        bool value = (Random.value > 0.5f);
        return value;
    }

    int getDirectionY()
    {
        if(getRandomBool())
        {
            directionY = 5;
        }
        else
        {
            directionY = -5;
        }  
        return directionY;
    }

    int getDirectionX()
    {
        if(getRandomBool())
        {
            directionX = 5;
        }
        else
        {
            directionX = -5;
        }
        return directionX;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "LimitTop" || collision.collider.name == "LimitBot")
        {
            movement.y = -movement.y;
            soundScript.wallBeep();
        }

        if(collision.collider.name == "PlayerOne" || collision.collider.name == "PlayerTwo")
        {
            movement.x = -movement.x;
            speed += 0.1f;
            soundScript.playerBeep();
        }
    }

}
