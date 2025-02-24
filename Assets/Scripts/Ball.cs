using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Ball Singleton;
    // Start is called before the first frame update
    private Rigidbody2D ballRb;
    void Start()
    {
        Singleton = this;
        ballRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            ballRb.velocity = new Vector2(Random.value, Random.value).normalized * 10f;
        }
    }
}
