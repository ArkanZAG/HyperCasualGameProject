using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameController.Instance.StopGame();
        Debug.Log("anjeng");
    }
    
}
