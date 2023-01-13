using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float speed = 20f;
    
    void Update()
    {
        transform.position += new Vector3(15.5f * Time.deltaTime, 0, 0);
    }

   
}
