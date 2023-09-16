using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI scoreText;


   private void Awake()
   {
      this.gameObject.SetActive(false);
   }

   public void Display(int score)
   {
      scoreText.text = score.ToString();
      this.gameObject.SetActive(true);
   }
}
