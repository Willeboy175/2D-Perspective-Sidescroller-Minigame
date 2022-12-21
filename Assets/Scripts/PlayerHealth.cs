using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D player;
    [SerializeField]
    int playerHealth = 5;
    Vector3 respawnPos;

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
            ResetPlayer();
            playerHealth = 5;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
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
}
