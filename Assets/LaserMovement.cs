using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    public float laserSpeed;

    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, laserSpeed * Time.deltaTime, 0);
        if(transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
}
