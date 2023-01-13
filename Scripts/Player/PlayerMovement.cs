using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed = 5;

    private Vector2 SSize;

    private void Start()
    {
        SSize = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y < SSize.y - transform.localScale.y)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
            }
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.y > -SSize.y + transform.localScale.y)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
            }
        }
    }
   
}
