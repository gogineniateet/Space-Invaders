using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemyBulletPrefab;
    public Vector3 offset;



    public void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(enemyPrefab, new Vector2(-8f + i,3), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {   
        Instantiate(enemyBulletPrefab, transform.position + offset, Quaternion.identity);

    }



}
