using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    Rigidbody2D enemy;
    Vector3 dir;
    float EnemySpeed = 3;
    KeyCode höger;
    KeyCode vänster;

    // Start is called before the first frame update
    void Start()
    {
        enemy.GetComponent<Rigidbody2D>();
    }

    private void Reset()
    {
        if (Input.GetKey(vänster) && transform.position.y < 4)
        {

            transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
            print("Åker vänster");
        }
        if (Input.GetKey(höger) && transform.position.y > -5)
        {

            transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
            print("Åker höger");


        }


        transform.position = new Vector3(0, 0, 0);
        int x = Random.Range(0, 2);
        if (x == 0)
        {
            x = -1;
        }
        dir = new Vector3(x, Random.Range(-1, 2), 0);
    }


    
}
