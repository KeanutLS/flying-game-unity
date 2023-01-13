using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public Transform[] EnemySpawns;
    public GameObject EnemyPrefab;
    private float spawntime;
    public float time;
    void Update()
    {
        spawntime += Time.deltaTime;
        
        if (spawntime >= time)
        {
            Invoke("Spawn", 2);
            
            spawntime = 0;

        }

        

    }
    void Spawn()
    {
        int RandomEnemy = Random.Range(0, 1);
        int RandomSpawn = Random.Range(0, EnemySpawns.Length);
        Instantiate(EnemyPrefab, EnemySpawns[RandomSpawn].position, transform.rotation);
        
    }









   
}
    
    
    

    
