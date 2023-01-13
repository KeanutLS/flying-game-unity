using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDieByBullet : MonoBehaviour
{
    public GameObject BulletPrefab;
    public int enemyhp;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullets")
        {
            enemyhp -= 10;
            if (enemyhp <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
        }
    }
}
