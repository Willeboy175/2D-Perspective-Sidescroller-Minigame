using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour

{
    public float speed = 0.8f;
    public float range = 3f;

    float startingX;
    private int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        startingX = transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime * direction);
        if (transform.position.x < startingX || transform.position.x > startingX + range)
        {
            direction *= -1;
        }
        
    }
}
