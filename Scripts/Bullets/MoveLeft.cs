using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    
    public float speed = 2f;

    void Update()
    {
        transform.position += new Vector3(- 7.5f * Time.deltaTime * speed, 0, 0);
    }
    
   
}
