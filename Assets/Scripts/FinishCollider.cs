using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameController.Instance.Finish();
    }
}
