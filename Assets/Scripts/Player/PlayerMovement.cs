
using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float limitValue;
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MovePlayer();
        }
    }

    private void MovePlayer()
    {
        float halfScreen = Screen.width / 2;
        float xPosition = (Input.mousePosition.x - halfScreen) / halfScreen;
        float finalXPosition = Mathf.Clamp(xPosition * limitValue, -limitValue, limitValue);
        playerTransform.localPosition = new Vector3(finalXPosition, 0, 0);
    }
}
