using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BossHpAndDeath : MonoBehaviour
{
    public GameObject BulletPrefab;
    public int BossHP;
    private float timer;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullets" && collision.gameObject.name != "BossBullet")
        {
            Destroy(collision.gameObject);
            BossHP -= 10;
            if (BossHP <= 0)
            {
                
                Destroy(gameObject);
                SceneManager.LoadScene("VictoryScreen");
                
                
            }
        }
    }
    
}
