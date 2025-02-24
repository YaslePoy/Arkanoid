using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Block;
    public Transform BasePoint;
    public float BlockHeight;
    public float BlockWidth;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(Block, BasePoint.position, Quaternion.identity);
            Instantiate(Block, BasePoint.position + new Vector3(BlockWidth, 0), Quaternion.identity);
            Instantiate(Block, BasePoint.position + new Vector3(-BlockWidth, 0), Quaternion.identity);
            Instantiate(Block, BasePoint.position + new Vector3(0, BlockHeight), Quaternion.identity);
            Instantiate(Block, BasePoint.position + new Vector3(0, -BlockHeight), Quaternion.identity);
        }
    }
}