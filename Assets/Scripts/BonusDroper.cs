using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BonusDroper : MonoBehaviour
{
    public GameObject[] BonusPrefabs;
    private System.Random random = new();
    private void OnDestroy()
    {
        var rand = random.Next() % BonusPrefabs.Length;
        Instantiate(BonusPrefabs[rand], transform.position, Quaternion.identity);
    }
}
