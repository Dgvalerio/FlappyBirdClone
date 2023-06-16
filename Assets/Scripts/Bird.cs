using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D _collision;
    public GameObject gameOver;
    
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

    private void OnCollisionEnter2D()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
