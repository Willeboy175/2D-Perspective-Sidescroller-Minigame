using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    Rigidbody2D enemy;
    Vector3 dir;
    float EnemySpeed = 3;
    KeyCode h�ger;
    KeyCode v�nster;

    // Start is called before the first frame update
    void Start()
    {
        enemy.GetComponent<Rigidbody2D>();
    }

    private void Reset()
    {
        if (Input.GetKey(v�nster) && transform.position.y < 4)
        {

            transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
            print("�ker v�nster");
        }
        if (Input.GetKey(h�ger) && transform.position.y > -5)
        {

            transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
            print("�ker h�ger");


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
