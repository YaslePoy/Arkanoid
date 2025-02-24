using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update\
    private float _startHeight;
    private Rigidbody2D _platformRb;
    public float Bounds;
    public float Radius;
    void Start()
    {
        _startHeight = transform.position.y;
        _platformRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var delta = (mousePos - transform.position).x;
        // transform.position = new Vector2(transform.position.x, _startHeight);
        // delta = Math.Sign(delta) * 2;
        //
        // delta = Math.Sign(delta) * 5;

        transform.position = new Vector2(Math.Sign(mousePos.x) * Mathf.Min(Mathf.Abs(mousePos.x), Bounds), _startHeight);
        transform.rotation = Quaternion.identity;
        // _platformRb.velocity = new Vector2(delta, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        var posDelta = other.contacts[0].point.x - transform.position.x;
        
        var otherRb = other.gameObject.GetComponent<Rigidbody2D>();
        
        otherRb.velocity = new Vector2(posDelta, Radius).normalized * otherRb.velocity.magnitude;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var component = other.gameObject.GetComponent<Bonus>();
        component.Handle.Apply();
        Destroy(other.gameObject);
    }
}
