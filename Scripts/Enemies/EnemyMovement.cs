using UnityEngine;

public class EnemyMovement : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-7.5f * Time.deltaTime, 0, 0) ;
      
    }

    

}
