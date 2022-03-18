using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    public float laserSpeed;
    ScoreManager score;

    public  void Start()
    {
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, laserSpeed * Time.deltaTime, 0);
        if(transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") 
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            score.ScoreUpdate(10);
        }
    }
}
