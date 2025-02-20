using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D ballRb;
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            ballRb.velocity = new Vector2(Random.value, Random.value) * 10f;
        }
    }
}
