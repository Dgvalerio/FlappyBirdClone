using System;
using UnityEngine;

public class Points : MonoBehaviour
{
    private GameController _controller;

    private void Start()
    {
        _controller = FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter2D()
    {
        _controller.score++;
        _controller.scoreText.text = _controller.score.ToString();
    }
}
