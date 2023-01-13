using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShootScrpit : MonoBehaviour
{
    public Transform ShootingPoint;
    public GameObject Bullets;

    public Transform[] BulletSpawns;
    public GameObject BulletPrefabs;

    private float ShootDelay;
    
    void Update()
    {
        ShootDelay += Time.deltaTime;
        float time = 0.5f;
        if (ShootDelay >= time)
        {
            {
                Shoot();
                ShootDelay = 0f;
            }

        }
    }
    private void Shoot()
    {
        Spawn();
        
        
    }
    void Spawn()
    {
        
        int RandomSpawn = Random.Range(0, BulletSpawns.Length);
        Instantiate(BulletPrefabs, BulletSpawns[RandomSpawn].position, transform.rotation);
    }
}
