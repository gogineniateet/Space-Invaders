using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed;
    public int enemyPoint = 0;

    void Start()
    {
        
    }


    void Update()
    {
        //transform.position = new Vector2(transform.position.x + enemySpeed * Time.deltaTime, transform.position.y);

        if (enemyPoint == 0)
        {
            transform.Translate(Vector2.right * enemySpeed *Time.deltaTime);
        }
        else if (enemyPoint == 1)
        {
            transform.Translate(Vector2.left *  enemySpeed  *Time.deltaTime);
        }
        if (transform.position.x > 8.0f)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 1f);
            enemyPoint = 1;
        }
        if (transform.position.x < -8.0f)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 1f);
            enemyPoint = 0;
        }

    }
}
