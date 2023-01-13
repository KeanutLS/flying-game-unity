using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootScript : MonoBehaviour
{
    public Transform ShootingPoint;
    public GameObject Bullets;

    private float ShootDelay;
    public float time;
    
    void Update()
    {
        ShootDelay += Time.deltaTime;
        
        if (ShootDelay >= time)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                Shoot();
                ShootDelay = 0f;
            }
            
        }
        
    }
    private void Shoot()
    {
        Instantiate(Bullets, ShootingPoint.position, ShootingPoint.rotation);
    }
}
