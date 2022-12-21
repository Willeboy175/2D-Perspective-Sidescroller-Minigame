using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D player;
    [SerializeField]
    int playerHealth = 3;
    Vector3 respawnPos;
    public GameObject pauseMenu;
    public GameObject gameOverMenu;

    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<Rigidbody2D>();

        respawnPos = player.position;

        ResetPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth <= 0)
        {
            RestartButton();
            ResetPlayer();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerHealth += -1;
        }
    }
    private void ResetPlayer()
    {
        transform.position = respawnPos;
    }

    public void RestartButton()
    {
        pauseMenu.SetActive(false);
        gameOverMenu.SetActive(true);
    }
}
