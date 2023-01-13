using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDespawnScript : MonoBehaviour
{
    public GameObject EnemyPrefab;

    private void OnBecameInvisible()
    {
        Destroy(EnemyPrefab);
        
    }
   
}
