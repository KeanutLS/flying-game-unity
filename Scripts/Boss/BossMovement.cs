using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public GameObject Boss;
    Vector3 BossPos;
    public float Speed;
    private void Update()
    {
        Move();
    }

    public void Move()
    {
        BossPos = transform.position;

        float y = Mathf.PingPong(Time.time * Speed, 1) * 6 - 3;
        Boss.transform.position = new Vector3(BossPos.x ,y, 0);
    }
}
