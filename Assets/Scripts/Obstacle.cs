using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private AudioClip bumpAudio;
    [SerializeField] private AudioSource sourceAudio;
    private void OnTriggerEnter(Collider other)
    {
        GameController.Instance.StopGame();
        Debug.Log("anjeng");
        sourceAudio.clip = bumpAudio;
        sourceAudio.Play();
    }
    
}
