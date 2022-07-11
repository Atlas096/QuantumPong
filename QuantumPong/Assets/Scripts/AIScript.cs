using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour
{
    public GameObject ball;
    private float ballPositionY;
    private float selfPositionY;
    Vector3 movement = new Vector3(0, 0.01f, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!ball) ball = GameObject.FindWithTag("Ball");
        else
        {
            ballPositionY = ball.transform.position.y;
            selfPositionY = this.transform.position.y;
            if(this.selfPositionY > ballPositionY)
            {
                transform.position -= movement;
            }
            if(this.selfPositionY < ballPositionY)
            {
                transform.position += movement;
            }
        }
    }
}
