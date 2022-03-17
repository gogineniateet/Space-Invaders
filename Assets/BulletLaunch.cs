using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLaunch : MonoBehaviour
{
    public GameObject laserPrefab;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefab, transform.position + offset, Quaternion.identity);
        }
    }
}
