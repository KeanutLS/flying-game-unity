using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDespawnOfScreen : MonoBehaviour
{
    public GameObject BulletPrefab;

    private void OnBecameInvisible()
    {
        Destroy(BulletPrefab);
        
    }
   
}
