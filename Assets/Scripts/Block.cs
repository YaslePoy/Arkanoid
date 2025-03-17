using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

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
            GameManager.Instance.CurrentUser.balance += Random.Range(0, 10);
            if (FindObjectsOfType<DynamicTexture>().Length == 1)
            {
                Debug.Log("Level finished");
                GameManager.Instance.CurrentUser.balance += 500;
                StartCoroutine(Api.UpdateUser());
                // SceneManager.CreateScene("DeadScene");
                SceneManager.LoadScene(3);
            }
        }
    }
}
