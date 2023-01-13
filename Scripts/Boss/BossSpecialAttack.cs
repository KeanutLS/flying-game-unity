using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpecialAttack : MonoBehaviour
{
    public Transform ShootingPoint;
    

    public Transform BulletSpawns;
    public GameObject BulletPrefabs;

    private float ShootDelay;
    public float SpecialDelay;
    void Update()
    {
        ShootDelay += Time.deltaTime;
       
        if (ShootDelay >= SpecialDelay)
        {
            SpecialAttack();
            ShootDelay = 0f;

        }
        
    }
    
    private void SpecialAttack()
    {
        SpecialAttacks();

        Instantiate(BulletPrefabs, ShootingPoint.position, ShootingPoint.rotation);

    }
    void SpecialAttacks()
    {
        
        
        Instantiate(BulletPrefabs, BulletSpawns.position, transform.rotation);
    }
}
