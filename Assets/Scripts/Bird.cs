using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D _collision;
    
    private void Start()
    {
        _collision = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _collision.velocity = Vector2.up * speed;
        }
    }
}
