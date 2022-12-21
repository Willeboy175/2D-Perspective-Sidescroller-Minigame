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
        //Returns to main menu if health is 0, escape key is pressed or player gets to the end of the level - William Strandberg
        if (playerHealth <= 0 || Input.GetKeyDown(KeyCode.Escape) || player.position.x > 90)
        {
            SceneManager.LoadScene("Main menu");
        }
    }

    //Lowers player health if player touches object with the tag "Enemy" - William Strandberg
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerHealth += -1;
        }
    }
}
