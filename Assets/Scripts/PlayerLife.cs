using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public static int playerLife = 3;
    public bool isGameOver;
    public GameObject gameOverPanel;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerLife == 0)
        {
            isGameOver = true;
            gameOverPanel.SetActive(true);
            player.SetActive(false);
            //Debug.Log("Game Over");
        }
    }
}
