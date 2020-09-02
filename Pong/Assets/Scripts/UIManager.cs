using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI _player1Score, _player2Score;
    private int _p1Score, _p2Score;

    void Start()
    {
        _player1Score.text = "" + 0;

        _player2Score.text = "" + 0;
    }

    public void UpdateP1Score()
    {
        _p1Score++;
        _player1Score.text = "" + _p1Score.ToString();
    }

    public void UpdateP2Score()
    {
        _p2Score++;
        _player2Score.text = "" + _p2Score.ToString();
    }

}
