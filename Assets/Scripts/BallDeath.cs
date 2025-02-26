using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDeath : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (FindObjectsOfType<Ball>().Length != 1)
            {
                Destroy(other.gameObject);
                return;
            }
            
            var ball = other.gameObject.GetComponent<Ball>();
            ball.HandleDeath();
        }
    }
}
