using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Ball Singleton;
    // Start is called before the first frame update
    private Rigidbody2D ballRb;
    private Vector3 ballPos;
    public int Lifes;
    public GameObject LifesHolder;
    void Start()
    {
        Singleton = this;
        ballRb = GetComponent<Rigidbody2D>();
        ballPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ballRb.velocity == Vector2.zero)
        {
            ballRb.velocity = new Vector2(Random.value, Random.value).normalized * 10f;
        }
    }

    public void HandleDeath()
    {
        if (--Lifes == 0)
        {
            Debug.Log("Ball dead");
            Lifes = 3;
        }
        
        
        ballRb.velocity = Vector2.zero;
        transform.position = ballPos;
        var hearts = LifesHolder.GetComponentsInChildren<SpriteRenderer>();
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].enabled = i + 1 <= Lifes;
        }

        Debug.Log(Lifes.ToString());
    }
}
