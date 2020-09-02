using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollider : MonoBehaviour
{
    private UIManager _uiManager;
    public BallMovement ball;
    public AudioSource _jotaro;
    public AudioSource _dio;

    private void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        ball = GetComponent<BallMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "RightWall")
        {
            Debug.Log("Player 1 Scored");
            _uiManager.UpdateP1Score();
            ball.Reset();
        }

        if (collision.tag == "Player")
        {
            _dio.Play();
        }

        if (collision.tag == "Player2")
        {
            _jotaro.Play();
        }

        else if (collision.tag == "LeftWall")
        {
            Debug.Log("Player 2 Scored");
            _uiManager.UpdateP2Score();
            ball.Reset();
        }
    }
}
