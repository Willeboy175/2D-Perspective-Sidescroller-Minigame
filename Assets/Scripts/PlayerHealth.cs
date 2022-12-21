using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth <= 0 || Input.GetKeyDown(KeyCode.Escape) || player.position.x > 90)
        {
            SceneManager.LoadScene("Main menu");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerHealth += -1;
        }
    }
}
