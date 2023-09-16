using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointObject : MonoBehaviour
{
    [SerializeField] private int point;
    [SerializeField] private GameObject visual;

    public void OnTriggerEnter(Collider other)
    {
        GameController.Instance.AddScore(point);
        Debug.Log("blog");
        visual.SetActive(false);
    }
}
