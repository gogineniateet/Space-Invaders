using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * playerSpeed * inputX * Time.deltaTime);
        if(transform.position.x < -8)
        {
            transform.position = new Vector2(-8, transform.position.y);
        }
        if(transform.position.x > 8)
        {
            transform.position = new Vector2(8, transform.position.y);
        }
    }
}
