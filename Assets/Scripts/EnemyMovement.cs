using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed;
    public int enemyPoint = 0;
    public GameObject enemyBulletPrefab;
    public Vector3 offset;
    public float time;


    void Update()
    {
        //transform.position = new Vector2(transform.position.x + enemySpeed * Time.deltaTime, transform.position.y);
        time = time + Time.deltaTime;
        if (time > 3f)
        {
            Instantiate(enemyBulletPrefab, transform.position + offset, Quaternion.identity);
            time = 0f;
        }
        
        if (enemyPoint == 0)
        {
            RightMovement();
        }
        else if (enemyPoint == 1)
        {
            LeftMovement();
        }
    }
    void RightMovement()
    {
        transform.Translate(Vector2.right * enemySpeed * Time.deltaTime);
    }    
    void LeftMovement()
    {
        transform.Translate(Vector2.left * enemySpeed * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "RightCollider")
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 1f);
            enemyPoint = 1;
        }
        if (collision.transform.tag == "LeftCollider")
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 1f);
            enemyPoint = 0;
        }
    }
   
}
