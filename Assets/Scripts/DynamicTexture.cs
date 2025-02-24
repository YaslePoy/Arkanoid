using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicTexture : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] _variants;
    public int CurrentSprite;
    public Block CurrentBlock;
    void Start()
    {
        _variants = FindFirstObjectByType<SpriteStorage>().Sprites;
        CurrentBlock = GetComponent<Block>();
        CurrentSprite = CurrentBlock.Lifes - 1;
        Instantiate(_variants[CurrentSprite], transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentSprite != CurrentBlock.Lifes - 1)
        {
            CurrentSprite = CurrentBlock.Lifes - 1;
            if (CurrentSprite == -1)
                return;
            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }

            Instantiate(_variants[CurrentSprite], transform);
        }
    }
}
