using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Vector3 movement = new Vector3(0, 0.01f, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x == -8.5f)
        {
            if(transform.position.y <= 11.2f)
            {
                if(Input.GetKey(KeyCode.UpArrow))
                {
                    transform.position += movement;
                }
            }

            if(transform.position.y >= 3.8f)
            {
                if(Input.GetKey(KeyCode.DownArrow))
                {
                    transform.position -= movement;
                }
            }
        }

        if(transform.position.x == 8.5f)
        {
            if(transform.position.y <= 11.2f)
            {
                if(Input.GetKey(KeyCode.W))
                {
                    transform.position += movement;
                }
            }

            if(transform.position.y >= 3.8f)
            {
                if(Input.GetKey(KeyCode.S))
                {
                    transform.position -= movement;
                }
            }
        }

    }
}
