using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI scoreText;
   [SerializeField] private Button retryButton;


   private void Awake()
   {
      this.gameObject.SetActive(false);
      retryButton.onClick.AddListener(OnRetry);
   }

   private void OnRetry()
   {
      SceneManager.LoadScene(0);
   }

   public void Display(int score)
   {
      scoreText.text = score.ToString();
      this.gameObject.SetActive(true);
   }
}
