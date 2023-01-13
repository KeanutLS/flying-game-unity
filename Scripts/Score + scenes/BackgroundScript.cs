using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{

    public float speed;
    public Renderer BGR;

    void Update()
    {
        BGR.material.mainTextureOffset += new Vector2(speed*Time.deltaTime, 0);
    }
}
