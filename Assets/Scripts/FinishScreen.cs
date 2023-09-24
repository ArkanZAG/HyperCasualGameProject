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
    }

    private void OnRetry()
    {
        SceneManager.LoadScene(0);
    }

    public void Display(int score)
    {
        scoreText.text = score.ToString();
    }

}
