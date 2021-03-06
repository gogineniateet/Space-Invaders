using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public static int playerLife = 3;
    public Text Health;
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
            Destroy(player);
            Debug.Log("GameOver");
            gameOverPanel.SetActive(true);
        }
    }
    
    public void PlayerHealth(int playerHealth)
    {
        
        playerLife = playerLife + playerHealth;
        Health.text = playerLife.ToString();
        Debug.Log(playerLife);
    }
}
