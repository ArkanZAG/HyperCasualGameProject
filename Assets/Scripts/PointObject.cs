using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointObject : MonoBehaviour
{
    [SerializeField] private int point;
    [SerializeField] private GameObject visual;
    [SerializeField] private AudioClip pickUpSound;
    [SerializeField] private AudioSource sourceAudio;

    public void OnTriggerEnter(Collider other)
    {
        GameController.Instance.AddScore(point);
        Debug.Log("blog");
        visual.SetActive(false);
        sourceAudio.clip = pickUpSound;
        sourceAudio.Play();
    }
}
