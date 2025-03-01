using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    void Start()
    {
        anim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.enabled = true;
            Destroy(gameObject);
        }
    }
}
