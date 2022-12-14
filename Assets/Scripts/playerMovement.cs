using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D player;
    [SerializeField]
    float playerSpeed = 1f;
    [SerializeField]
    float jumpHeight = 1f;
    [SerializeField]
    float dashSpeed = 1f;
    [SerializeField]
    float dashRecharge = 1f;
    float timer = 0f;
    bool touchingGround;
    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) && touchingGround == true)
        {
            player.AddForce(new Vector2(playerSpeed * Time.fixedDeltaTime, 0), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.A) && touchingGround == true)
        {
            player.AddForce(new Vector2(playerSpeed * -1 * Time.fixedDeltaTime, 0), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.W) && touchingGround == true)
        {
            player.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.D) && timer > dashRecharge)
        {
            player.AddForce(new Vector2(dashSpeed, 0), ForceMode2D.Impulse);
            timer = 0f;
        }

        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.A) && timer > dashRecharge)
        {
            player.AddForce(new Vector2(dashSpeed * -1, 0), ForceMode2D.Impulse);
            timer = 0f;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            touchingGround = true;
        }
        else
        {
            touchingGround = false;
        }
    }

     void OnCollisionExit2D(Collision2D collision)
    {
        touchingGround = false;
    }
}
