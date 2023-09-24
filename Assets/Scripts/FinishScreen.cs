using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class FinishScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI finishText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Button restartButton;
    [SerializeField] private Button mainMenuButton;


    private void Awake()
    {
        this.gameObject.SetActive(false);
        restartButton.onClick.AddListener(OnRetry);
        mainMenuButton.onClick.AddListener(MainMenu);
    }

    private void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void OnRetry()
    {
        SceneManager.LoadScene("Game");
    }

    public void Display(int score)
    {
        this.gameObject.SetActive(true);
        scoreText.text = score.ToString();
    }

}
