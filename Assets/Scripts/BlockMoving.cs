using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMoving : MonoBehaviour
{
    // Start is called before the first frame update
    public float Distance;
    public float Speed;
    public bool Horizontal;
    public bool Vertical;
    private Vector3 _startup;
    void Start()
    {
        _startup = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var hor = Horizontal ? 1 : 0;
        var vert = Vertical ? 1 : 0;
        gameObject.transform.position = _startup + new Vector3(hor * Mathf.Sin(Time.timeSinceLevelLoad * Speed) * Distance, vert * Mathf.Cos(Time.timeSinceLevelLoad * Speed) * Distance, 0);
    }
}
