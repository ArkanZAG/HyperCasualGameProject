using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private bool isPlaying = true;
    [SerializeField] private int score;
    [SerializeField] private GameOverScreen gameOverScreen;
    [SerializeField] private Animator playerAnimator;
        public static GameController Instance;

    private void Awake()
    {
        Instance = this;
    }

    public bool GetIsPlaying()
    {
        return isPlaying;
    }

    public void StopGame()
    {
        isPlaying = false;
        gameOverScreen.Display(score);
        playerAnimator.SetTrigger("Dead");
    }

    public void AddScore(int value)
    {
        score = score + value;
    }

}
