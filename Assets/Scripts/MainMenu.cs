using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class MainMenu : MonoBehaviour
{
   [SerializeField] private Button startButton;
   [SerializeField] private Button exitButton;

   private void Awake()
   {
      startButton.onClick.AddListener(GameStart);
      exitButton.onClick.AddListener(ExitGame);
   }

   private void GameStart()
   {
      SceneManager.LoadScene("Game");
   }

   private void ExitGame()
   {
      Debug.Log("quit");
      Application.Quit();
   }
   
}
