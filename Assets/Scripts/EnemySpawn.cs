using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;

   


    public void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(enemyPrefab, new Vector2(-6f + i,3), Quaternion.identity);
        }
    }

   
    void Update()
    {   
        

    }



}
