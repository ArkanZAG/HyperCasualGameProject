using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private bool isPlaying = true;
    [SerializeField] private int score;
    [SerializeField] private GameOverScreen gameOverScreen;
    public static GameController Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void StopGame()
    {
        isPlaying = false;
        gameOverScreen.Display(score);
    }

    public void AddScore(int value)
    {
        score = score + value;
    }

}
