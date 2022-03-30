using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float time;
    public GameObject enemyBullet;

    public void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            GameObject temp = Instantiate(enemyPrefab, new Vector2(-6f + i,3), Quaternion.identity);
            temp.name = "Enemy" + i;
            //Instantiate(enemyPrefab, new Vector2(-6f + i, 1), Quaternion.identity);

        }
    }

    private void Update()
    {
        int i = Random.Range(0, 5);

        GameObject enemy = GameObject.Find("Enemy" + i);
        time = time + Time.deltaTime;
        if (time >= 3.5f && enemy != null)
        {
            Vector3 enemyPosition = enemy.transform.position;
            Instantiate(enemyBullet, enemyPosition + new Vector3(0f, -0.8f, 0f), Quaternion.identity);
            //Debug.Log("Bullet launching from"+enemy.name);
            time = 0f;

        }



    }
}
