using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{
    public int Lifes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (--Lifes == 0)
        {
            Destroy(gameObject);
            if (FindObjectsOfType<DynamicTexture>().Length == 1)
            {
                Debug.Log("Level finished");
                // SceneManager.CreateScene("DeadScene");
                SceneManager.LoadScene(3);
            }
        }
    }
}
