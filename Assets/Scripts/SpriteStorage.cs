using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public class SpriteStorage : MonoBehaviour
{
    // Start is called before the first frame update
    [FormerlySerializedAs("sprites")] [SerializeField]
    public GameObject[] Sprites;
    public void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}