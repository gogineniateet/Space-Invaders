using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    public float bulletMovement;
    PlayerLife health;


    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.Find("GameManager").GetComponent<PlayerLife>();
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(0, -bulletMovement * Time.deltaTime, 0);     
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            health.PlayerHealth(-1);
            Destroy(gameObject);
            //Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Bunker")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
